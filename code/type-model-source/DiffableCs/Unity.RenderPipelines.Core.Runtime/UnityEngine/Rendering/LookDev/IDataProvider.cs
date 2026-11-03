namespace UnityEngine.Rendering.LookDev;

[Token(Token = "0x20002CB")]
public interface IDataProvider
{

	[Token(Token = "0x1700026A")]
	public IEnumerable<String> supportedDebugModes
	{
		[Token(Token = "0x60013C2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60013C7")]
	public void Cleanup(StageRuntimeInterface SRI) { }

	[Token(Token = "0x60013C0")]
	public void FirstInitScene(StageRuntimeInterface stage) { }

	[Token(Token = "0x60013C2")]
	public IEnumerable<String> get_supportedDebugModes() { }

	[Token(Token = "0x60013C4")]
	public void GetShadowMask(ref RenderTexture output, StageRuntimeInterface stage) { }

	[Token(Token = "0x60013C5")]
	public void OnBeginRendering(StageRuntimeInterface stage) { }

	[Token(Token = "0x60013C6")]
	public void OnEndRendering(StageRuntimeInterface stage) { }

	[Token(Token = "0x60013C3")]
	public void UpdateDebugMode(int debugIndex) { }

	[Token(Token = "0x60013C1")]
	public void UpdateSky(Camera camera, Sky sky, StageRuntimeInterface stage) { }

}

