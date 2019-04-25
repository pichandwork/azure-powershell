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
    /// Defines the New-AzFrontDoorRulesEngineHeaderAction cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorRouteConfigurationObject", DefaultParameterSetName = FieldsWithForwardingParameterSet), OutputType(typeof(PSRouteConfiguration))]
    public class NewFrontDoorRouteConfigurationObject : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// The resource group name that the RoutingRule will be created in.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "The resource group name that the RoutingRule will be created in.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Front Door name.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "The name of the Front Door to which this routing rule belongs.")]
        [ValidateNotNullOrEmpty]
        public string FrontDoorName { get; set; }

        /// <summary>
        /// The name of BackendPool which this rule routes to
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "The name of the BackendPool which this rule routes to")]
        [ValidateNotNullOrEmpty]
        public string BackendPoolName { get; set; }

        /// <summary>
        /// The custom path used to rewrite resource paths matched by this rule. Leave empty to use incoming path.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "The custom path used to rewrite resource paths matched by this rule. Leave empty to use incoming path.")]
        public string CustomForwardingPath { get; set; }

        /// <summary>
        /// The protocol this rule will use when forwarding traffic to backends.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "The protocol this rule will use when forwarding traffic to backends. Default value is MatchRequest")]
        [PSArgumentCompleter("HttpOnly", "HttpsOnly", "MatchRequest")]
        public string ForwardingProtocol { get; set; }

        /// <summary>
        /// Whether to enable caching for this route.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "Whether to enable caching for this route. Default value is false")]
        public bool EnableCaching { get; set; }

        /// <summary>
        /// The treatment of URL query terms when forming the cache key.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "The treatment of URL query terms when forming the cache key. Default value is StripAll")]
        [PSArgumentCompleter("StripNone", "StripAll")]
        public string QueryParameterStripDirective { get; set; }

        /// <summary>
        /// Whether to use dynamic compression for cached content
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithForwardingParameterSet, HelpMessage = "Whether to enable dynamic compression for cached content. Default value is Enabled")]
        public PSEnabledState DynamicCompression { get; set; }

        /// <summary>
        /// The redirect type the rule will use when redirecting traffic.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithRedirectParameterSet, HelpMessage = "The redirect type the rule will use when redirecting traffic. Default Value is Moved")]
        [PSArgumentCompleter("Moved", "Found", "TemporaryRedirect", "PermanentRedirect")]
        public string RedirectType { get; set; }

        /// <summary>
        /// The protocol of the destination to where the traffic is redirected
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithRedirectParameterSet, HelpMessage = "The protocol of the destination to where the traffic is redirected. Default value is MatchRequest")]
        [PSArgumentCompleter("HttpOnly", "HttpsOnly", "MatchRequest")]
        public string RedirectProtocol { get; set; }

        /// <summary>
        /// Host to redirect. Leave empty to use use the incoming host as the destination host.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithRedirectParameterSet, HelpMessage = "Host to redirect. Leave empty to use use the incoming host as the destination host.")]
        public string CustomHost { get; set; }

        /// <summary>
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination path.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithRedirectParameterSet, HelpMessage = "The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination path.")]
        public string CustomPath { get; set; }

        /// <summary>
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithRedirectParameterSet, HelpMessage = "Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.")]
        public string CustomFragment { get; set; }

        /// <summary>
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string; leave empty to preserve the incoming query string. Query string must be in <key>=<value> format. The first ? and & will be added automatically so do not include them in the front, but do separate multiple query strings with &.
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = FieldsWithRedirectParameterSet, HelpMessage = "The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string; leave empty to preserve the incoming query string. Query string must be in <key>=<value> format. The first ? and & will be added automatically so do not include them in the front, but do separate multiple query strings with &.")]
        public string CustomQueryString { get; set; }

        public override void ExecuteCmdlet()
        {

        }
    }
}