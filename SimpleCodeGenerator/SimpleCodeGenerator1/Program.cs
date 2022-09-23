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
foreach (var output in generatorOutput)
{
	// the output file path (create parent dirs if not exists)
	var outputFilePath =  Path.Combine(projectDirectory, $"Output/{output.FileName}");
	Directory.CreateDirectory(Path.GetDirectoryName(outputFilePath)!);
	File.WriteAllText(outputFilePath, output.Contents);
}
