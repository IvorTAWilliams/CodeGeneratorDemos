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
    
    
    public partial class _EntityPage_ts_tt_ceb73e23_08d7_4235_8ec1_2cddc1c5befc : BaseTemplate<EntityTemplate> {
        
        
        #line 54 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"

    public override string RelativeFilePath => $"Clientside/src/Views/Pages/{Model.Entity.Name}Page.tsx";

        #line default
        #line hidden
        
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("import React, { useState } from \'react\'\r\nimport { useCreate, useDelete, useRead }" +
                    " from \'../../Hooks/CrudHooks\'\r\nimport { ");
            
            #line default
            #line hidden
            
            #line 5 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 5 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(" } from \'../../Models/");
            
            #line default
            #line hidden
            
            #line 5 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 5 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("\'\r\nimport ");
            
            #line default
            #line hidden
            
            #line 6 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 6 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("Attributes from \'../Components/");
            
            #line default
            #line hidden
            
            #line 6 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 6 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("Attributes\'\r\n\r\nconst ");
            
            #line default
            #line hidden
            
            #line 8 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 8 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("Page = () => {\r\n  const { data, refetchFn } = useRead(\'");
            
            #line default
            #line hidden
            
            #line 9 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 9 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("\');\r\n  const [model, setModel] = useState<");
            
            #line default
            #line hidden
            
            #line 10 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 10 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(">({});\r\n  const createFn = useCreate(\'");
            
            #line default
            #line hidden
            
            #line 11 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 11 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("\');\r\n  const deleteFn = useDelete(\'");
            
            #line default
            #line hidden
            
            #line 12 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 12 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("\');\r\n\r\n  const onCreateModel = () => {\r\n    createFn(model)\r\n      .then(() => {\r" +
                    "\n        setModel({});\r\n        refetchFn();\r\n      });\r\n  }\r\n\r\n  const onDelete" +
                    "Model = (model: ");
            
            #line default
            #line hidden
            
            #line 22 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 22 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(") => {\r\n    deleteFn(model)\r\n      .then(() => {\r\n        setModel({});\r\n        " +
                    "refetchFn();\r\n      });\r\n  }\r\n\r\n  return (\r\n    <div>\r\n      <div>\r\n        <h2>" +
                    "Create a ");
            
            #line default
            #line hidden
            
            #line 33 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 33 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("</h2>\r\n        <");
            
            #line default
            #line hidden
            
            #line 34 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 34 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("Attributes model={model} onChange={(updatedModel) => setModel(updatedModel)} />\r\n" +
                    "        <button onClick={onCreateModel}>Create</button>\r\n      </div>\r\n      <di" +
                    "v>\r\n        <h2>All ");
            
            #line default
            #line hidden
            
            #line 38 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 38 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("s</h2>\r\n        {\r\n          data?.map(x =>\r\n            <>\r\n              <");
            
            #line default
            #line hidden
            
            #line 42 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 42 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("Attributes key={x.Id} model={x} readonly />\r\n              <button onClick={() =>" +
                    " onDeleteModel(x)}>Delete</button>\r\n            </>\r\n          )\r\n        }\r\n   " +
                    "   </div>\r\n    </div>\r\n  )\r\n}\r\nexport default ");
            
            #line default
            #line hidden
            
            #line 51 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Model.Entity.Name ));
            
            #line default
            #line hidden
            
            #line 51 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Clientside\src\Views\Pages\_EntityPage.ts.tt"
            this.Write("Page\r\n\r\n\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public override void Initialize() {
            base.Initialize();
        }
    }
}
