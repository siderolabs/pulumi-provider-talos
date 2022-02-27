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
    /// Talos cluster config resource
    /// </summary>
    [TalosResourceType("talos:index:clusterConfig")]
    public partial class ClusterConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// additional Subject-Alt-Names for the APIServer certificate
        /// </summary>
        [Output("additionalSans")]
        public Output<ImmutableArray<string>> AdditionalSans { get; private set; } = null!;

        /// <summary>
        /// cluster discovery feature
        /// </summary>
        [Output("clusterDiscovery")]
        public Output<bool> ClusterDiscovery { get; private set; } = null!;

        /// <summary>
        /// The cluster endpoint
        /// </summary>
        [Output("clusterEndpoint")]
        public Output<string> ClusterEndpoint { get; private set; } = null!;

        /// <summary>
        /// cluster name
        /// </summary>
        [Output("clusterName")]
        public Output<string> ClusterName { get; private set; } = null!;

        /// <summary>
        /// generated machineconfigs (applied to all node types)
        /// </summary>
        [Output("configPatches")]
        public Output<Outputs.ConfigPatches> ConfigPatches { get; private set; } = null!;

        /// <summary>
        /// generated machineconfigs (applied to 'controlplane' types)
        /// </summary>
        [Output("configPatchesControlPlane")]
        public Output<Outputs.ConfigPatches> ConfigPatchesControlPlane { get; private set; } = null!;

        /// <summary>
        /// generated machineconfigs (applied to 'worker' type)
        /// </summary>
        [Output("configPatchesWorker")]
        public Output<Outputs.ConfigPatches> ConfigPatchesWorker { get; private set; } = null!;

        /// <summary>
        /// the desired machine config version to refer to
        /// </summary>
        [Output("configVersion")]
        public Output<string> ConfigVersion { get; private set; } = null!;

        /// <summary>
        /// Talos Controlplane Config
        /// </summary>
        [Output("controlplaneConfig")]
        public Output<string> ControlplaneConfig { get; private set; } = null!;

        /// <summary>
        /// the dns domain to use for cluster
        /// </summary>
        [Output("dnsDomain")]
        public Output<string> DnsDomain { get; private set; } = null!;

        /// <summary>
        /// machine config documentation enabled
        /// </summary>
        [Output("docs")]
        public Output<bool> Docs { get; private set; } = null!;

        /// <summary>
        /// machine config examples enabled
        /// </summary>
        [Output("examples")]
        public Output<bool> Examples { get; private set; } = null!;

        /// <summary>
        /// the disk to install to 
        /// </summary>
        [Output("installDisk")]
        public Output<string> InstallDisk { get; private set; } = null!;

        /// <summary>
        /// the image used to perform an installation
        /// </summary>
        [Output("installImage")]
        public Output<string> InstallImage { get; private set; } = null!;

        /// <summary>
        /// desired kubernetes version to run
        /// </summary>
        [Output("kubernetesVersion")]
        public Output<string> KubernetesVersion { get; private set; } = null!;

        /// <summary>
        /// kubespan enabled
        /// </summary>
        [Output("kubespan")]
        public Output<bool> Kubespan { get; private set; } = null!;

        /// <summary>
        /// persist value for configs
        /// </summary>
        [Output("persist")]
        public Output<bool> Persist { get; private set; } = null!;

        /// <summary>
        /// list of registry mirrors
        /// </summary>
        [Output("registryMirrors")]
        public Output<ImmutableArray<string>> RegistryMirrors { get; private set; } = null!;

        /// <summary>
        /// Talos Secrets Bundle
        /// </summary>
        [Output("secrets")]
        public Output<Outputs.SecretsBundle> Secrets { get; private set; } = null!;

        /// <summary>
        /// Talos Config
        /// </summary>
        [Output("talosConfig")]
        public Output<string> TalosConfig { get; private set; } = null!;

        /// <summary>
        /// the desired Talos version
        /// </summary>
        [Output("talosVersion")]
        public Output<string> TalosVersion { get; private set; } = null!;

        /// <summary>
        /// Talos Worker Config
        /// </summary>
        [Output("workerConfig")]
        public Output<string> WorkerConfig { get; private set; } = null!;


        /// <summary>
        /// Create a ClusterConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ClusterConfig(string name, ClusterConfigArgs args, CustomResourceOptions? options = null)
            : base("talos:index:clusterConfig", name, args ?? new ClusterConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ClusterConfig(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("talos:index:clusterConfig", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "secrets",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ClusterConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ClusterConfig Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ClusterConfig(name, id, options);
        }
    }

    public sealed class ClusterConfigArgs : Pulumi.ResourceArgs
    {
        [Input("additionalSans")]
        private InputList<string>? _additionalSans;

        /// <summary>
        /// additional Subject-Alt-Names for the APIServer certificate
        /// </summary>
        public InputList<string> AdditionalSans
        {
            get => _additionalSans ?? (_additionalSans = new InputList<string>());
            set => _additionalSans = value;
        }

        /// <summary>
        /// enable cluster discovery feature (default true)
        /// </summary>
        [Input("clusterDiscovery")]
        public Input<bool>? ClusterDiscovery { get; set; }

        /// <summary>
        /// The cluster endpoint is the URL for the Kubernetes API. If you decide to use
        /// a control plane node, common in a single node control plane setup, use port 6443 as
        /// this is the port that the API server binds to on every control plane node. For an HA
        /// setup, usually involving a load balancer, use the IP and port of the load balancer.
        /// </summary>
        [Input("clusterEndpoint", required: true)]
        public Input<string> ClusterEndpoint { get; set; } = null!;

        /// <summary>
        /// cluster name
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// patch generated machineconfigs (applied to all node types)
        /// </summary>
        [Input("configPatches")]
        public Input<Inputs.ConfigPatchesArgs>? ConfigPatches { get; set; }

        /// <summary>
        /// patch generated machineconfigs (applied to 'controlplane' types)
        /// </summary>
        [Input("configPatchesControlPlane")]
        public Input<Inputs.ConfigPatchesArgs>? ConfigPatchesControlPlane { get; set; }

        /// <summary>
        /// patch generated machineconfigs (applied to 'worker' type)
        /// </summary>
        [Input("configPatchesWorker")]
        public Input<Inputs.ConfigPatchesArgs>? ConfigPatchesWorker { get; set; }

        /// <summary>
        /// the desired machine config version to refer to
        /// </summary>
        [Input("configVersion")]
        public Input<Inputs.TalosMachineConfigVersionOutputArgs>? ConfigVersion { get; set; }

        /// <summary>
        /// the dns domain to use for cluster (default "cluster.local")
        /// </summary>
        [Input("dnsDomain")]
        public Input<string>? DnsDomain { get; set; }

        /// <summary>
        /// renders all machine configs adding the documentation for each field (default true)
        /// </summary>
        [Input("docs")]
        public Input<bool>? Docs { get; set; }

        /// <summary>
        /// renders all machine configs with the commented examples (default true)
        /// </summary>
        [Input("examples")]
        public Input<bool>? Examples { get; set; }

        /// <summary>
        /// the disk to install to (default "/dev/sda")
        /// </summary>
        [Input("installDisk")]
        public Input<string>? InstallDisk { get; set; }

        /// <summary>
        /// the image used to perform an installation (default "ghcr.io/talos-systems/installer:v0.14.2")
        /// </summary>
        [Input("installImage")]
        public Input<string>? InstallImage { get; set; }

        /// <summary>
        /// desired kubernetes version to run (default "1.23.4")
        /// </summary>
        [Input("kubernetesVersion")]
        public Input<string>? KubernetesVersion { get; set; }

        /// <summary>
        /// enable kubespan feature
        /// </summary>
        [Input("kubespan")]
        public Input<bool>? Kubespan { get; set; }

        /// <summary>
        /// the desired persist value for configs (default true)
        /// </summary>
        [Input("persist")]
        public Input<bool>? Persist { get; set; }

        [Input("registryMirrors")]
        private InputList<string>? _registryMirrors;

        /// <summary>
        /// list of registry mirrors to use in format: &lt;registry host&gt;=&lt;mirror URL&gt;
        /// </summary>
        public InputList<string> RegistryMirrors
        {
            get => _registryMirrors ?? (_registryMirrors = new InputList<string>());
            set => _registryMirrors = value;
        }

        [Input("secrets", required: true)]
        private Input<Inputs.SecretsBundleArgs>? _secrets;

        /// <summary>
        /// Talos Secrets Bundle
        /// </summary>
        public Input<Inputs.SecretsBundleArgs>? Secrets
        {
            get => _secrets;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secrets = Output.Tuple<Input<Inputs.SecretsBundleArgs>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// the desired Talos version to refer to
        /// </summary>
        [Input("talosVersion")]
        public Input<Inputs.TalosVersionOutputArgs>? TalosVersion { get; set; }

        public ClusterConfigArgs()
        {
            ClusterDiscovery = true;
            DnsDomain = "cluster.local";
            Docs = true;
            Examples = true;
            InstallDisk = "/dev/sda";
            InstallImage = "ghcr.io/talos-systems/installer:v0.14.2";
            KubernetesVersion = "1.23.4";
            Persist = true;
        }
    }
}
