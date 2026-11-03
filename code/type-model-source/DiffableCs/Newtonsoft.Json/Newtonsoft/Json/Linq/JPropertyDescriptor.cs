namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000178")]
public class JPropertyDescriptor : PropertyDescriptor
{

	[Token(Token = "0x17000203")]
	public virtual Type ComponentType
	{
		[Address(RVA = "0x217A8B0", Offset = "0x2179CB0", Length = "0x4D")]
		[Token(Token = "0x6000C72")]
		 get { } //Length: 77
	}

	[Token(Token = "0x17000204")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C73")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000206")]
	protected virtual int NameHashCode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C75")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000205")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
		[Token(Token = "0x6000C74")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x217A8A0", Offset = "0x2179CA0", Length = "0xB")]
	[Token(Token = "0x6000C6B")]
	public JPropertyDescriptor(string name) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C6D")]
	public virtual bool CanResetValue(object component) { }

	[Address(RVA = "0x217A660", Offset = "0x2179A60", Length = "0x72")]
	[Token(Token = "0x6000C6C")]
	private static JObject CastInstance(object instance) { }

	[Address(RVA = "0x217A8B0", Offset = "0x2179CB0", Length = "0x4D")]
	[Token(Token = "0x6000C72")]
	public virtual Type get_ComponentType() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C73")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C75")]
	protected virtual int get_NameHashCode() { }

	[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
	[Token(Token = "0x6000C74")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x217A6E0", Offset = "0x2179AE0", Length = "0x97")]
	[NullableContext(2)]
	[Token(Token = "0x6000C6E")]
	public virtual object GetValue(object component) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C6F")]
	public virtual void ResetValue(object component) { }

	[Address(RVA = "0x217A780", Offset = "0x2179B80", Length = "0x11B")]
	[NullableContext(2)]
	[Token(Token = "0x6000C70")]
	public virtual void SetValue(object component, object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C71")]
	public virtual bool ShouldSerializeValue(object component) { }

}

