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
    
    
    public partial class StorageProvider_ts_tt_53c337bc_93a9_473b_8bf6_e54cbc22b4c2 : BaseTemplate<ProjectTemplate> {
        
        
        #line 33 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Serverside\src\Services\StorageProvider.ts.tt"

    public override string RelativeFilePath => $"Serverside/src/Services/StorageProvider.ts";

        #line default
        #line hidden
        
        
        public override string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "P:\CodeGeneratorDemos\SimpleCodeGenerator\FullStackCodeGenerator\MDE\Templates\Serverside\src\Services\StorageProvider.ts.tt"
            this.Write(@"import { Injectable } from '@nestjs/common';
import { BaseEntity } from 'src/Models/BaseEntity';
import { v4 as uuidv4 } from 'uuid';

@Injectable()
export class StorageProvider {
  private InMemoryStorage: {[key: string]: Array<BaseEntity> | undefined} = {}

  Create<T extends BaseEntity>(model: T, modelName: string): T {
    model.Id = model.Id ?? uuidv4();
    this.InMemoryStorage[modelName] = !this.InMemoryStorage[modelName] ? [model] : [...this.InMemoryStorage[modelName], model]
    return model;
  }

  Read<T extends BaseEntity>(modelName: string): Array<T> {
    return this.InMemoryStorage[modelName] as T[];
  }

  Update<T extends BaseEntity>(model: T, modelName: string): T {
    const index = this.InMemoryStorage[modelName].findIndex(x => x.Id === model.Id);
    this.InMemoryStorage[modelName][index] = model;
    return model;
  }

  Delete<T extends BaseEntity>(model: T, modelName: string): T {
    this.InMemoryStorage[modelName] = this.InMemoryStorage[modelName].filter(x => x.Id !== model.Id);
    return model;
  }
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
