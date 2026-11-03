namespace Unity.Cinemachine;

[Token(Token = "0x2000052")]
public interface ICinemachineTargetGroup
{

	[Token(Token = "0x1700002D")]
	public Bounds BoundingBox
	{
		[Token(Token = "0x600015A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002F")]
	public bool IsEmpty
	{
		[Token(Token = "0x600015C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002B")]
	public bool IsValid
	{
		[Token(Token = "0x6000158")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002E")]
	public BoundingSphere Sphere
	{
		[Token(Token = "0x600015B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002C")]
	public Transform Transform
	{
		[Token(Token = "0x6000159")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600015A")]
	public Bounds get_BoundingBox() { }

	[Token(Token = "0x600015C")]
	public bool get_IsEmpty() { }

	[Token(Token = "0x6000158")]
	public bool get_IsValid() { }

	[Token(Token = "0x600015B")]
	public BoundingSphere get_Sphere() { }

	[Token(Token = "0x6000159")]
	public Transform get_Transform() { }

	[Token(Token = "0x600015E")]
	public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }

	[Token(Token = "0x600015D")]
	public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer, bool includeBehind) { }

}

