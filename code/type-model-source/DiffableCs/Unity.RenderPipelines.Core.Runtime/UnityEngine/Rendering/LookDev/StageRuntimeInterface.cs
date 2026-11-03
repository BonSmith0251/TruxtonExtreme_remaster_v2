namespace UnityEngine.Rendering.LookDev;

[Token(Token = "0x20002CD")]
public class StageRuntimeInterface
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D0C")]
	private Func<Boolean, GameObject> m_AddGameObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D0D")]
	private Func<Camera> m_GetCamera; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D0E")]
	private Func<Light> m_GetSunLight; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D0F")]
	public object SRPData; //Field offset: 0x28

	[Token(Token = "0x1700026B")]
	public Camera camera
	{
		[Address(RVA = "0x2CBF540", Offset = "0x2CBE940", Length = "0x1B")]
		[Token(Token = "0x60013CA")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700026C")]
	public Light sunLight
	{
		[Address(RVA = "0x2CBF560", Offset = "0x2CBE960", Length = "0x1B")]
		[Token(Token = "0x60013CB")]
		 get { } //Length: 27
	}

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x60013C8")]
	public StageRuntimeInterface(Func<Boolean, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight) { }

	[Address(RVA = "0x2CBF520", Offset = "0x2CBE920", Length = "0x1B")]
	[Token(Token = "0x60013C9")]
	public GameObject AddGameObject(bool persistent = false) { }

	[Address(RVA = "0x2CBF540", Offset = "0x2CBE940", Length = "0x1B")]
	[Token(Token = "0x60013CA")]
	public Camera get_camera() { }

	[Address(RVA = "0x2CBF560", Offset = "0x2CBE960", Length = "0x1B")]
	[Token(Token = "0x60013CB")]
	public Light get_sunLight() { }

}

