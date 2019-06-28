// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Management.Automation;
using System.Net;
using Microsoft.Azure.Commands.FrontDoor.Common;
using Microsoft.Azure.Commands.FrontDoor.Helpers;
using Microsoft.Azure.Commands.FrontDoor.Models;
using Microsoft.Azure.Commands.FrontDoor.Properties;
using Microsoft.Azure.Management.FrontDoor;
using System.Linq;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.FrontDoor.Cmdlets
{
    /// <summary>
    /// Defines the Update-AzFrontDoorRulesEngine cmdlet.
    /// </summary>
    [Cmdlet("Update", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorRulesEngine", SupportsShouldProcess = true, DefaultParameterSetName = FieldsParameterSet), OutputType(typeof(PSRulesEngine))]
    public class UpdateFrontDoorRulesEngine : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// The resource group name that the rules engine will be created in.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = FieldsParameterSet, HelpMessage = "The resource group name that the rules engine will be created in.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The Front Door name.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = FieldsParameterSet, HelpMessage = "Front Door name.")]
        [ValidateNotNullOrEmpty]
        public string FrontDoorName { get; set; }

        /// <summary>
        /// The name of the rule engine.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = FieldsParameterSet, HelpMessage = "The name of the rule engine.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        ///The Rules Engine object to update.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = ObjectParameterSet, ValueFromPipeline = true, HelpMessage = "The Rules Engine object to update.")]
        [ValidateNotNullOrEmpty]
        public PSRulesEngine InputObject { get; set; }

        /// <summary>
        /// Resource Id of the Front Door to update
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = ResourceIdParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "Resource Id of the Front Door to update")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        /// <summary>
        /// A list of rules that define a particular Rules Engine Configuration.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "A list of rules that define a particular Rules Engine Configuration.")]
        public PSRulesEngineRule[] Rules { get; set; }

        public override void ExecuteCmdlet()
        {
        }
    }
}
