//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullStackCodeGenerator {
    using SimpleCodeGenerator;
    using System;
    
    
    public partial class _EntityAttributes_ts_tt_ddad8a3c_1e03_4c10_8a4b_3811ef5235ea : BaseTemplate<EntityTemplate> {
        
        
        #line 32 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"

    public override string RelativeFilePath => $"Clientside/src/Views/Components/{Model.Entity.Name}Attributes.tsx";

        #line default
        #line hidden
        
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("import React from \'react\'\r\nimport { ");
            
            #line default
            #line hidden
            
            #line 4 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 4 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(" } from \'../../Models/");
            
            #line default
            #line hidden
            
            #line 4 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 4 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("\';\r\n\r\ninterface ");
            
            #line default
            #line hidden
            
            #line 6 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 6 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("AttributesProps {\r\n  model: ");
            
            #line default
            #line hidden
            
            #line 7 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 7 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(";\r\n  readonly?: boolean;\r\n  onChange?: (model: ");
            
            #line default
            #line hidden
            
            #line 9 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 9 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(") => void;\r\n}\r\n\r\nconst ");
            
            #line default
            #line hidden
            
            #line 12 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 12 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("Attributes = (props: ");
            
            #line default
            #line hidden
            
            #line 12 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 12 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("AttributesProps) => (\r\n  <div className=\'attributes\'>\r\n");
            
            #line default
            #line hidden
            
            #line 14 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"

    foreach (var attribute in Model.Entity.Attributes)
    {

            
            #line default
            #line hidden
            
            #line 18 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("    <div className=\'attribute\'>\r\n      <span>");
            
            #line default
            #line hidden
            
            #line 19 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( attribute.Name ));
            
            #line default
            #line hidden
            
            #line 19 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("</span>\r\n      <input\r\n        disabled={props.readonly}\r\n        value={props.mo" +
                    "del.");
            
            #line default
            #line hidden
            
            #line 22 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( attribute.Name ));
            
            #line default
            #line hidden
            
            #line 22 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("}\r\n        onChange={x => props.onChange ? props.onChange({ ...props.model, ");
            
            #line default
            #line hidden
            
            #line 23 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( attribute.Name ));
            
            #line default
            #line hidden
            
            #line 23 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(": x.target.value }) : null} />\r\n    </div>\r\n");
            
            #line default
            #line hidden
            
            #line 25 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"

    }

            
            #line default
            #line hidden
            
            #line 28 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("  </div>\r\n)\r\nexport default ");
            
            #line default
            #line hidden
            
            #line 30 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 30 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Components\_EntityAttributes.ts.tt"
            this.Write("Attributes\r\n\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public override void Initialize() {
            base.Initialize();
        }
    }
}