namespace UnityEngine.Rendering.Universal;

[Obsolete("This is not longer supported Please use DebugDisplaySettingsVolume. #from(6000.2)")]
[Token(Token = "0x2000070")]
public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
{

	[Token(Token = "0x170000C2")]
	public virtual LayerMask selectedCameraLayerMask
	{
		[Address(RVA = "0x2D8A9F0", Offset = "0x2D89DF0", Length = "0xE2")]
		[Token(Token = "0x60002AE")]
		 get { } //Length: 226
	}

	[Token(Token = "0x170000C3")]
	public virtual Vector3 selectedCameraPosition
	{
		[Address(RVA = "0x2D8AAE0", Offset = "0x2D89EE0", Length = "0xFA")]
		[Token(Token = "0x60002AF")]
		 get { } //Length: 250
	}

	[Token(Token = "0x170000C1")]
	public virtual VolumeStack selectedCameraVolumeStack
	{
		[Address(RVA = "0x2D8ABE0", Offset = "0x2D89FE0", Length = "0x12B")]
		[Token(Token = "0x60002AD")]
		 get { } //Length: 299
	}

	[Obsolete("This property is obsolete and kept only for not breaking user code. VolumeDebugSettings will use current pipeline when it needs to gather volume component types and paths. #from(2023.2)")]
	[Token(Token = "0x170000C4")]
	public virtual Type targetRenderPipeline
	{
		[Address(RVA = "0x2D8AD10", Offset = "0x2D8A110", Length = "0x4D")]
		[Token(Token = "0x60002B0")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x2D8A990", Offset = "0x2D89D90", Length = "0x5A")]
	[Token(Token = "0x60002B1")]
	public UniversalRenderPipelineVolumeDebugSettings() { }

	[Address(RVA = "0x2D8A9F0", Offset = "0x2D89DF0", Length = "0xE2")]
	[Token(Token = "0x60002AE")]
	public virtual LayerMask get_selectedCameraLayerMask() { }

	[Address(RVA = "0x2D8AAE0", Offset = "0x2D89EE0", Length = "0xFA")]
	[Token(Token = "0x60002AF")]
	public virtual Vector3 get_selectedCameraPosition() { }

	[Address(RVA = "0x2D8ABE0", Offset = "0x2D89FE0", Length = "0x12B")]
	[Token(Token = "0x60002AD")]
	public virtual VolumeStack get_selectedCameraVolumeStack() { }

	[Address(RVA = "0x2D8AD10", Offset = "0x2D8A110", Length = "0x4D")]
	[Token(Token = "0x60002B0")]
	public virtual Type get_targetRenderPipeline() { }

}

