// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Talos.Inputs
{

    /// <summary>
    /// Talos SecretsBundle type
    /// </summary>
    public sealed class SecretsBundleArgs : Pulumi.ResourceArgs
    {
        [Input("Certs")]
        public Input<Inputs.CertsArgs>? Certs { get; set; }

        [Input("Cluster")]
        public Input<Inputs.ClusterArgs>? Cluster { get; set; }

        [Input("Secrets")]
        public Input<Inputs.SecretsArgs>? Secrets { get; set; }

        [Input("TrustdInfo")]
        public Input<Inputs.TrustdInfoArgs>? TrustdInfo { get; set; }

        public SecretsBundleArgs()
        {
        }
    }
}