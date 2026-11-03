namespace UnityEngine.Rendering;

[Obsolete("This is not longer supported Please use DebugDisplaySettingsVolume. #from(6000.2)")]
[Token(Token = "0x20000D5")]
public interface IVolumeDebugSettings2 : IVolumeDebugSettings
{

	[Obsolete("This property is obsolete and kept only for not breaking user code. VolumeDebugSettings will use current pipeline when it needs to gather volume component types and paths. #from(2023.2)")]
	[Token(Token = "0x170000BA")]
	public Type targetRenderPipeline
	{
		[Token(Token = "0x60007A3")]
		 get { } //Length: 0
	}

	[Obsolete("This property is obsolete and kept only for not breaking user code. VolumeDebugSettings will use current pipeline when it needs to gather volume component types and paths. #from(2023.2)")]
	[Token(Token = "0x170000BB")]
	public List<ValueTuple`2<String, Type>> volumeComponentsPathAndType
	{
		[Token(Token = "0x60007A4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60007A3")]
	public Type get_targetRenderPipeline() { }

	[Token(Token = "0x60007A4")]
	public List<ValueTuple`2<String, Type>> get_volumeComponentsPathAndType() { }

}

