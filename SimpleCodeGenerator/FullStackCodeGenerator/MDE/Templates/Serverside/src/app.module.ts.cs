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
    
    
    public partial class app_module_ts_tt_02a0f461_aa58_4c90_898a_16e9141d3d1e : BaseTemplate<ProjectTemplate> {
        
        
        #line 14 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Serverside\src\app.module.ts.tt"

    public override string RelativeFilePath => $"Serverside/src/app.module.ts";

        #line default
        #line hidden
        
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Serverside\src\app.module.ts.tt"
            this.Write(@"import { BookController } from './Controllers/BookController';
import { Module } from '@nestjs/common';
import { StorageProvider } from './Services/StorageProvider';

@Module({
  imports: [],
  controllers: [BookController],
  providers: [StorageProvider],
})
export class AppModule {}

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
