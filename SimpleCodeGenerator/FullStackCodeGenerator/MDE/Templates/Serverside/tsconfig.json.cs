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
    
    
    public partial class tsconfig_json_tt_6309481d_8b5a_4423_a041_106eed16b5c5 : BaseTemplate<ProjectTemplate> {
        
        
        #line 28 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Serverside\tsconfig.json.tt"

    public override string RelativeFilePath => $"Serverside/tsconfig.json";

        #line default
        #line hidden
        
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Serverside\tsconfig.json.tt"
            this.Write(@"{
  ""compilerOptions"": {
    ""module"": ""commonjs"",
    ""declaration"": true,
    ""removeComments"": true,
    ""emitDecoratorMetadata"": true,
    ""experimentalDecorators"": true,
    ""allowSyntheticDefaultImports"": true,
    ""target"": ""es2017"",
    ""sourceMap"": true,
    ""outDir"": ""./dist"",
    ""baseUrl"": ""./"",
    ""incremental"": true,
    ""skipLibCheck"": true,
    ""strictNullChecks"": false,
    ""noImplicitAny"": false,
    ""strictBindCallApply"": false,
    ""forceConsistentCasingInFileNames"": false,
    ""noFallthroughCasesInSwitch"": false
  },
  ""include"": [
    ""src""
  ]
}

");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public override void Initialize() {
            base.Initialize();
        }
    }
}
