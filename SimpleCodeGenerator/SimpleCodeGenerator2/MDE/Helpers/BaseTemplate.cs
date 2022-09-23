namespace SimpleCodeGenerator;

public abstract class BaseTemplate<T>
{
	public virtual string RelativeFilePath { get; }
	public virtual bool? DoGenerate { get; }

	public virtual T Model { get; set; }

	public virtual BaseTemplate<T> InjectModel(T model)
	{
		Model = model;
		return this;
	}

	public virtual void Initialize()
	{
		throw new System.NotImplementedException();
	}
	public virtual string TransformText()
	{
		throw new System.NotImplementedException();
	}

	private global::System.Text.StringBuilder builder;

	private global::System.Collections.Generic.IDictionary<string, object> session;

	private global::System.CodeDom.Compiler.CompilerErrorCollection errors;

	private string currentIndent = string.Empty;

	private global::System.Collections.Generic.Stack<int> indents;

	private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();

	public virtual global::System.Collections.Generic.IDictionary<string, object> Session
	{
		get { return this.session; }
		set { this.session = value; }
	}

	public global::System.Text.StringBuilder GenerationEnvironment
	{
		get
		{
			if ((this.builder == null))
			{
				this.builder = new global::System.Text.StringBuilder();
			}
			return this.builder;
		}
		set { this.builder = value; }
	}

	protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors
	{
		get
		{
			if ((this.errors == null))
			{
				this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
			}
			return this.errors;
		}
	}

	public string CurrentIndent
	{
		get { return this.currentIndent; }
	}

	private global::System.Collections.Generic.Stack<int> Indents
	{
		get
		{
			if ((this.indents == null))
			{
				this.indents = new global::System.Collections.Generic.Stack<int>();
			}
			return this.indents;
		}
	}

	public ToStringInstanceHelper ToStringHelper
	{
		get { return this._toStringHelper; }
	}

	public void Write(string textToAppend)
	{
		GenerationEnvironment.Append(textToAppend);
	}

	public class ToStringInstanceHelper
	{

		private IFormatProvider formatProvider = System.Globalization.CultureInfo.InvariantCulture;

		public IFormatProvider FormatProvider
		{
			get => formatProvider;
			set
			{
				if ((value != null))
				{
					formatProvider = value;
				}
			}
		}

		public string ToStringWithCulture(object objectToConvert)
		{
			if ((objectToConvert == null))
			{
				throw new ArgumentNullException("objectToConvert");
			}
			var type = objectToConvert.GetType();
			var iConvertibleType = typeof(global::System.IConvertible);
			if (iConvertibleType.IsAssignableFrom(type))
			{
				return ((IConvertible) (objectToConvert)).ToString(this.formatProvider);
			}
			var methInfo = type.GetMethod("ToString", new global::System.Type[]
			{
				iConvertibleType
			});
			if ((methInfo != null))
			{
				return (string) methInfo.Invoke(objectToConvert, new object[]
				{
					formatProvider
				})!;
			}
			return objectToConvert.ToString()!;
		}
	}
}