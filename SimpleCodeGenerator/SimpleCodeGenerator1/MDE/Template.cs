//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleCodeGenerator2 {
    using SimpleCodeGenerator;
    using System;
    
    
    public partial class Template_tt_9eda5fbc_f7a1_4aba_a4ab_6bcff14bf2d5 : BaseTemplate<EntityTemplate> {
        
        
        #line 16 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"

    public override string RelativeFilePath => $"{Model.Entity.Name}.tsx";

        #line default
        #line hidden
        
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write("\r\nexport default class ");
            
            #line default
            #line hidden
            
            #line 4 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 4 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 6 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"

	foreach (var attribute in Model.Entity.Attributes)
	{

            
            #line default
            #line hidden
            
            #line 10 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write("\t");
            
            #line default
            #line hidden
            
            #line 10 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( attribute.Name ));
            
            #line default
            #line hidden
            
            #line 10 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write(": ");
            
            #line default
            #line hidden
            
            #line 10 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( attribute.Type ));
            
            #line default
            #line hidden
            
            #line 10 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write(";\r\n");
            
            #line default
            #line hidden
            
            #line 11 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"

	}

            
            #line default
            #line hidden
            
            #line 14 "P:\CodeGeneratorDemos\SimpleCodeGenerator\SimpleCodeGenerator2\MDE\Template.tt"
            this.Write("}\r\n\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public override void Initialize() {
            base.Initialize();
        }
    }
}
