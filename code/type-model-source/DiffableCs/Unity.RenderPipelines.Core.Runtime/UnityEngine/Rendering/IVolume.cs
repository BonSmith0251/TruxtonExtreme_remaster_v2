namespace UnityEngine.Rendering;

[Token(Token = "0x20001EF")]
public interface IVolume
{

	[Token(Token = "0x170001DF")]
	public List<Collider> colliders
	{
		[Token(Token = "0x6000EB9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001DE")]
	public bool isGlobal
	{
		[Token(Token = "0x6000EB7")]
		 get { } //Length: 0
		[Token(Token = "0x6000EB8")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000EB9")]
	public List<Collider> get_colliders() { }

	[Token(Token = "0x6000EB7")]
	public bool get_isGlobal() { }

	[Token(Token = "0x6000EB8")]
	public void set_isGlobal(bool value) { }

}

