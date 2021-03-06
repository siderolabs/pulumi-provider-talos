// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Talos
{
    /// <summary>
    /// A node apply config resource
    /// </summary>
    [TalosResourceType("talos:index:nodeApplyConfig")]
    public partial class NodeApplyConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// node endpoint address
        /// </summary>
        [Output("endpoint")]
        public Output<string> Endpoint { get; private set; } = null!;

        /// <summary>
        /// allow insecure connections
        /// </summary>
        [Output("insecure")]
        public Output<bool> Insecure { get; private set; } = null!;

        /// <summary>
        /// machineconfig
        /// </summary>
        [Output("machineConfig")]
        public Output<AssetOrArchive> MachineConfig { get; private set; } = null!;

        /// <summary>
        /// machine config apply mode
        /// </summary>
        [Output("mode")]
        public Output<string> Mode { get; private set; } = null!;

        /// <summary>
        /// node address
        /// </summary>
        [Output("node")]
        public Output<string> Node { get; private set; } = null!;

        /// <summary>
        /// talosconfig
        /// </summary>
        [Output("talosConfig")]
        public Output<AssetOrArchive> TalosConfig { get; private set; } = null!;

        /// <summary>
        /// wait timeout in seconds
        /// </summary>
        [Output("timeout")]
        public Output<int> Timeout { get; private set; } = null!;


        /// <summary>
        /// Create a NodeApplyConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NodeApplyConfig(string name, NodeApplyConfigArgs args, CustomResourceOptions? options = null)
            : base("talos:index:nodeApplyConfig", name, args ?? new NodeApplyConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NodeApplyConfig(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("talos:index:nodeApplyConfig", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "machineConfig",
                    "talosConfig",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NodeApplyConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NodeApplyConfig Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NodeApplyConfig(name, id, options);
        }
    }

    public sealed class NodeApplyConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// node endpoint address
        /// </summary>
        [Input("endpoint", required: true)]
        public Input<string> Endpoint { get; set; } = null!;

        /// <summary>
        /// whether to use insecure connection
        /// </summary>
        [Input("insecure")]
        public Input<bool>? Insecure { get; set; }

        /// <summary>
        /// machineconfig
        /// </summary>
        [Input("machineConfig", required: true)]
        public Input<AssetOrArchive> MachineConfig { get; set; } = null!;

        /// <summary>
        /// machine config apply mode (default auto)
        /// </summary>
        [Input("mode")]
        public Input<Pulumi.Talos.TalosMachineConfigApplyMode>? Mode { get; set; }

        /// <summary>
        /// node address
        /// </summary>
        [Input("node", required: true)]
        public Input<string> Node { get; set; } = null!;

        /// <summary>
        /// talosconfig
        /// </summary>
        [Input("talosConfig", required: true)]
        public Input<AssetOrArchive> TalosConfig { get; set; } = null!;

        /// <summary>
        /// timeout in seconds (default 600)
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        public NodeApplyConfigArgs()
        {
            Insecure = false;
            Mode = Pulumi.Talos.TalosMachineConfigApplyMode.AUTO;
            Timeout = 600;
        }
    }
}
