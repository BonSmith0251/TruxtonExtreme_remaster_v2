namespace System.Security.Principal;

[ComVisible(True)]
[Token(Token = "0x200033D")]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
{
	[Token(Token = "0x4000DAB")]
	private static IntPtr invalidWindows; //Field offset: 0x0
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000DA5")]
	private IntPtr _token; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000DA6")]
	private string _type; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000DA7")]
	private WindowsAccountType _account; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000DA8")]
	private bool _authenticated; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000DA9")]
	private string _name; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000DAA")]
	private SerializationInfo _info; //Field offset: 0x98

	[Token(Token = "0x170002AC")]
	public virtual string AuthenticationType
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6001A2B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170002AD")]
	public virtual string Name
	{
		[Address(RVA = "0x1EF4130", Offset = "0x1EF3530", Length = "0x7D")]
		[Token(Token = "0x6001A2C")]
		 get { } //Length: 125
	}

	[Address(RVA = "0x1EF3EC0", Offset = "0x1EF32C0", Length = "0x3A")]
	[Token(Token = "0x6001A32")]
	private static WindowsIdentity() { }

	[Address(RVA = "0x1EF3F00", Offset = "0x1EF3300", Length = "0x1C9")]
	[Token(Token = "0x6001A26")]
	public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	[Address(RVA = "0x1EF40D0", Offset = "0x1EF34D0", Length = "0x53")]
	[Token(Token = "0x6001A27")]
	public WindowsIdentity(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EF35F0", Offset = "0x1EF29F0", Length = "0x9")]
	[ComVisible(False)]
	[Token(Token = "0x6001A28")]
	public override void Dispose() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6001A2B")]
	public virtual string get_AuthenticationType() { }

	[Address(RVA = "0x1EF4130", Offset = "0x1EF3530", Length = "0x7D")]
	[Token(Token = "0x6001A2C")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1EF3610", Offset = "0x1EF2A10", Length = "0x204")]
	[Token(Token = "0x6001A29")]
	public static WindowsIdentity GetCurrent() { }

	[Address(RVA = "0x1EF3600", Offset = "0x1EF2A00", Length = "0x5")]
	[Token(Token = "0x6001A30")]
	internal static IntPtr GetCurrentToken() { }

	[Address(RVA = "0x1EF3820", Offset = "0x1EF2C20", Length = "0x5")]
	[Token(Token = "0x6001A31")]
	private static string GetTokenName(IntPtr token) { }

	[Address(RVA = "0x1EF3830", Offset = "0x1EF2C30", Length = "0xB8")]
	[Token(Token = "0x6001A2A")]
	public override WindowsImpersonationContext Impersonate() { }

	[Address(RVA = "0x1EF38F0", Offset = "0x1EF2CF0", Length = "0x153")]
	[Token(Token = "0x6001A2F")]
	private void SetToken(IntPtr token) { }

	[Address(RVA = "0x1EF3A50", Offset = "0x1EF2E50", Length = "0x337")]
	[Token(Token = "0x6001A2D")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[Address(RVA = "0x1EF3D90", Offset = "0x1EF3190", Length = "0x12C")]
	[Token(Token = "0x6001A2E")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

