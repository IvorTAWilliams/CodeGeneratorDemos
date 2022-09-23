using System.Reflection;

namespace SimpleCodeGenerator;

public class GeneratorOutput
{
	public string Contents { get; set; }
	public string FileName { get; set; }
}

public static class TemplateGenerator
{
	public static List<GeneratorOutput> Generate<T>(T model)
	{
		return GetTemplates<BaseTemplate<T>>()
			.Select(template => template.InjectModel(model))
			.Select(template => new GeneratorOutput
			{
				Contents = template.TransformText(),
				FileName = template.RelativeFilePath
			})
			.ToList();
	}

	private static IEnumerable<T> GetTemplates<T>()
	{
		return Assembly.GetExecutingAssembly()
			.GetTypes()
			.Where(type => typeof(T).IsAssignableFrom(type) && !type.IsInterface)
			.Where(type => !type.IsAbstract)
			.Select(type => (T) Activator.CreateInstance(type)!).Where(instance => instance != null);
	}
}