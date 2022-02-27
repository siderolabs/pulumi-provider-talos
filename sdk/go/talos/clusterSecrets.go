// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package talos

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Talos secrets resource
type ClusterSecrets struct {
	pulumi.CustomResourceState

	ConfigVersion TalosMachineConfigVersionOutputTypeOutput `pulumi:"configVersion"`
	// Talos Secrets Bundle
	Secrets SecretsBundleOutput `pulumi:"secrets"`
	// Talos version the config generated for
	TalosVersion TalosVersionOutputOutput `pulumi:"talosVersion"`
}

// NewClusterSecrets registers a new resource with the given unique name, arguments, and options.
func NewClusterSecrets(ctx *pulumi.Context,
	name string, args *ClusterSecretsArgs, opts ...pulumi.ResourceOption) (*ClusterSecrets, error) {
	if args == nil {
		args = &ClusterSecretsArgs{}
	}

	if isZero(args.ConfigVersion) {
		args.ConfigVersion = pulumi.StringPtr("v1alpha1")
	}
	if args.Secrets != nil {
		args.Secrets = pulumi.ToSecret(args.Secrets).(SecretsBundleOutput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"secrets",
	})
	opts = append(opts, secrets)
	var resource ClusterSecrets
	err := ctx.RegisterResource("talos:index:clusterSecrets", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterSecrets gets an existing ClusterSecrets resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterSecrets(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterSecretsState, opts ...pulumi.ResourceOption) (*ClusterSecrets, error) {
	var resource ClusterSecrets
	err := ctx.ReadResource("talos:index:clusterSecrets", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterSecrets resources.
type clusterSecretsState struct {
}

type ClusterSecretsState struct {
}

func (ClusterSecretsState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterSecretsState)(nil)).Elem()
}

type clusterSecretsArgs struct {
	// the desired machine config version to generate (default "v1alpha1")
	ConfigVersion *string `pulumi:"configVersion"`
	// the desired Talos version to generate config for (backwards compatibility, e.g. v0.8)
	TalosVersion *string `pulumi:"talosVersion"`
}

// The set of arguments for constructing a ClusterSecrets resource.
type ClusterSecretsArgs struct {
	// the desired machine config version to generate (default "v1alpha1")
	ConfigVersion pulumi.StringPtrInput
	// the desired Talos version to generate config for (backwards compatibility, e.g. v0.8)
	TalosVersion pulumi.StringPtrInput
}

func (ClusterSecretsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterSecretsArgs)(nil)).Elem()
}

type ClusterSecretsInput interface {
	pulumi.Input

	ToClusterSecretsOutput() ClusterSecretsOutput
	ToClusterSecretsOutputWithContext(ctx context.Context) ClusterSecretsOutput
}

func (*ClusterSecrets) ElementType() reflect.Type {
	return reflect.TypeOf((**ClusterSecrets)(nil)).Elem()
}

func (i *ClusterSecrets) ToClusterSecretsOutput() ClusterSecretsOutput {
	return i.ToClusterSecretsOutputWithContext(context.Background())
}

func (i *ClusterSecrets) ToClusterSecretsOutputWithContext(ctx context.Context) ClusterSecretsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterSecretsOutput)
}

// ClusterSecretsArrayInput is an input type that accepts ClusterSecretsArray and ClusterSecretsArrayOutput values.
// You can construct a concrete instance of `ClusterSecretsArrayInput` via:
//
//          ClusterSecretsArray{ ClusterSecretsArgs{...} }
type ClusterSecretsArrayInput interface {
	pulumi.Input

	ToClusterSecretsArrayOutput() ClusterSecretsArrayOutput
	ToClusterSecretsArrayOutputWithContext(context.Context) ClusterSecretsArrayOutput
}

type ClusterSecretsArray []ClusterSecretsInput

func (ClusterSecretsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ClusterSecrets)(nil)).Elem()
}

func (i ClusterSecretsArray) ToClusterSecretsArrayOutput() ClusterSecretsArrayOutput {
	return i.ToClusterSecretsArrayOutputWithContext(context.Background())
}

func (i ClusterSecretsArray) ToClusterSecretsArrayOutputWithContext(ctx context.Context) ClusterSecretsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterSecretsArrayOutput)
}

// ClusterSecretsMapInput is an input type that accepts ClusterSecretsMap and ClusterSecretsMapOutput values.
// You can construct a concrete instance of `ClusterSecretsMapInput` via:
//
//          ClusterSecretsMap{ "key": ClusterSecretsArgs{...} }
type ClusterSecretsMapInput interface {
	pulumi.Input

	ToClusterSecretsMapOutput() ClusterSecretsMapOutput
	ToClusterSecretsMapOutputWithContext(context.Context) ClusterSecretsMapOutput
}

type ClusterSecretsMap map[string]ClusterSecretsInput

func (ClusterSecretsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ClusterSecrets)(nil)).Elem()
}

func (i ClusterSecretsMap) ToClusterSecretsMapOutput() ClusterSecretsMapOutput {
	return i.ToClusterSecretsMapOutputWithContext(context.Background())
}

func (i ClusterSecretsMap) ToClusterSecretsMapOutputWithContext(ctx context.Context) ClusterSecretsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterSecretsMapOutput)
}

type ClusterSecretsOutput struct{ *pulumi.OutputState }

func (ClusterSecretsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ClusterSecrets)(nil)).Elem()
}

func (o ClusterSecretsOutput) ToClusterSecretsOutput() ClusterSecretsOutput {
	return o
}

func (o ClusterSecretsOutput) ToClusterSecretsOutputWithContext(ctx context.Context) ClusterSecretsOutput {
	return o
}

type ClusterSecretsArrayOutput struct{ *pulumi.OutputState }

func (ClusterSecretsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ClusterSecrets)(nil)).Elem()
}

func (o ClusterSecretsArrayOutput) ToClusterSecretsArrayOutput() ClusterSecretsArrayOutput {
	return o
}

func (o ClusterSecretsArrayOutput) ToClusterSecretsArrayOutputWithContext(ctx context.Context) ClusterSecretsArrayOutput {
	return o
}

func (o ClusterSecretsArrayOutput) Index(i pulumi.IntInput) ClusterSecretsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ClusterSecrets {
		return vs[0].([]*ClusterSecrets)[vs[1].(int)]
	}).(ClusterSecretsOutput)
}

type ClusterSecretsMapOutput struct{ *pulumi.OutputState }

func (ClusterSecretsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ClusterSecrets)(nil)).Elem()
}

func (o ClusterSecretsMapOutput) ToClusterSecretsMapOutput() ClusterSecretsMapOutput {
	return o
}

func (o ClusterSecretsMapOutput) ToClusterSecretsMapOutputWithContext(ctx context.Context) ClusterSecretsMapOutput {
	return o
}

func (o ClusterSecretsMapOutput) MapIndex(k pulumi.StringInput) ClusterSecretsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ClusterSecrets {
		return vs[0].(map[string]*ClusterSecrets)[vs[1].(string)]
	}).(ClusterSecretsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterSecretsInput)(nil)).Elem(), &ClusterSecrets{})
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterSecretsArrayInput)(nil)).Elem(), ClusterSecretsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterSecretsMapInput)(nil)).Elem(), ClusterSecretsMap{})
	pulumi.RegisterOutputType(ClusterSecretsOutput{})
	pulumi.RegisterOutputType(ClusterSecretsArrayOutput{})
	pulumi.RegisterOutputType(ClusterSecretsMapOutput{})
}
