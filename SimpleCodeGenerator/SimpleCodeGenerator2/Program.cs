using Newtonsoft.Json;
using SimpleCodeGenerator;
using DiffMatchPatch;

// STEP-1: read in the model using the meta-model
var modelFile = File.ReadAllText("MDE/Model.json");
var model = JsonConvert.DeserializeObject<Project>(modelFile);

// STEP:2 for each entity in the model, generate output from the template
var generatorOutput = new List<GeneratorOutput>();
foreach (var entity in model.Entities)
{
	var generatorInput = new EntityTemplate
	{
		Entity = entity,
		Project = model
	};
	generatorOutput.AddRange(TemplateGenerator.Generate(generatorInput));
}

// STEP:3 write each output into a file
var projectDirectory = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName;

// run the patching algorithm for each output file
foreach (var output in generatorOutput)
{
	// the output file path (create parent dirs if not exists)
	var outputFilePath =  Path.Combine(projectDirectory, $"Output/{output.FileName}");
	Directory.CreateDirectory(Path.GetDirectoryName(outputFilePath)!);
	// the __generated__ file path (create parent dirs if not exists)
	var generatedFilePath =  Path.Combine(projectDirectory, $"__Generated__/{output.FileName}");
	Directory.CreateDirectory(Path.GetDirectoryName(generatedFilePath)!);

	// if there is no output file, must be first time so dont worry  about patching and write out the output directly
	if (!File.Exists(outputFilePath))
	{
		// write the patched output into the output path
		File.WriteAllText(outputFilePath, output.Contents);
		// save the raw generated file for future use with patching
		File.WriteAllText(generatedFilePath, output.Contents);
		continue;
	}

	// get the last __generated__ output (not touched by a developer)
	var lastGeneratedOutput = File.ReadAllText(generatedFilePath);
	// get the contents from the output directory (possible changed by a developer)
	var possiblyDeveloperOverwrittenFile = File.ReadAllText(outputFilePath);
	// get googles diff match patch ready
	var dmp = new diff_match_patch();
	// make a patch between the last generated output, and the new generated output
	var generatorPatches = dmp.patch_make(lastGeneratedOutput.RemoveCarriageReturns(), output.Contents.RemoveCarriageReturns());
	// apply the patch to the possibly developer overwritten output file
	var something =  dmp.patch_apply(generatorPatches, possiblyDeveloperOverwrittenFile.RemoveCarriageReturns());
	var patchedOutput = dmp.patch_apply(generatorPatches, possiblyDeveloperOverwrittenFile.RemoveCarriageReturns())[0].ToString();
	// write the patched output into the output path
	File.WriteAllText(outputFilePath, patchedOutput);
	// save the raw generated file for future use with patching
	File.WriteAllText(generatedFilePath, output.Contents);
}
