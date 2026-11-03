namespace System.Reflection;

[Token(Token = "0x20004DF")]
public abstract class EventInfo : MemberInfo
{
	[Token(Token = "0x20004E0")]
	private sealed class AddEventAdapter : MulticastDelegate
	{

		[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
		[Token(Token = "0x6002233")]
		public AddEventAdapter(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6002234")]
		public override void Invoke(object _this, Delegate dele) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001324")]
	private AddEventAdapter cached_add_event; //Field offset: 0x10

	[Token(Token = "0x17000422")]
	public override Type EventHandlerType
	{
		[Address(RVA = "0x1F34170", Offset = "0x1F33570", Length = "0x131")]
		[Token(Token = "0x600222C")]
		 get { } //Length: 305
	}

	[Token(Token = "0x17000421")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6002226")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6002225")]
	protected EventInfo() { }

	[Address(RVA = "0x1F338A0", Offset = "0x1F32CA0", Length = "0x8")]
	[Token(Token = "0x600222D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F34170", Offset = "0x1F33570", Length = "0x131")]
	[Token(Token = "0x600222C")]
	public override Type get_EventHandlerType() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6002226")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x1F340A0", Offset = "0x1F334A0", Length = "0x16")]
	[Token(Token = "0x6002227")]
	public override MethodInfo GetAddMethod() { }

	[Token(Token = "0x6002229")]
	public abstract MethodInfo GetAddMethod(bool nonPublic) { }

	[Address(RVA = "0x1F340C0", Offset = "0x1F334C0", Length = "0xAC")]
	[Token(Token = "0x6002232")]
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

	[Address(RVA = "0x1F338B0", Offset = "0x1F32CB0", Length = "0x7")]
	[Token(Token = "0x600222E")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x600222B")]
	public abstract MethodInfo GetRaiseMethod(bool nonPublic) { }

	[Address(RVA = "0x1EF5810", Offset = "0x1EF4C10", Length = "0x16")]
	[Token(Token = "0x6002228")]
	public override MethodInfo GetRemoveMethod() { }

	[Token(Token = "0x600222A")]
	public abstract MethodInfo GetRemoveMethod(bool nonPublic) { }

	[Address(RVA = "0x1F342B0", Offset = "0x1F336B0", Length = "0x5")]
	[Token(Token = "0x6002231")]
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	[Address(RVA = "0x1F339B0", Offset = "0x1F32DB0", Length = "0x29")]
	[Token(Token = "0x600222F")]
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	[Address(RVA = "0x1F342C0", Offset = "0x1F336C0", Length = "0x3E")]
	[Token(Token = "0x6002230")]
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

}

