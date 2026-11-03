namespace UnityEngine.Rendering;

[Token(Token = "0x20000EE")]
public interface IProbeVolumeEnabledRenderPipeline
{

	[Token(Token = "0x170000EE")]
	public ProbeVolumeSHBands maxSHBands
	{
		[Token(Token = "0x6000864")]
		 get { } //Length: 0
	}

	[Obsolete("This field is no longer necessary. #from(2023.3)")]
	[Token(Token = "0x170000EF")]
	public ProbeVolumeSceneData probeVolumeSceneData
	{
		[Token(Token = "0x6000865")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000ED")]
	public bool supportProbeVolume
	{
		[Token(Token = "0x6000863")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000864")]
	public ProbeVolumeSHBands get_maxSHBands() { }

	[Token(Token = "0x6000865")]
	public ProbeVolumeSceneData get_probeVolumeSceneData() { }

	[Token(Token = "0x6000863")]
	public bool get_supportProbeVolume() { }

}

