namespace System;

[Token(Token = "0x20001AB")]
public abstract class Delegate : ICloneable, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E8")]
	private IntPtr method_ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006E9")]
	private IntPtr invoke_impl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006EA")]
	private object m_target; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006EB")]
	private IntPtr method; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006EC")]
	private IntPtr delegate_trampoline; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006ED")]
	private IntPtr extra_arg; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006EE")]
	private IntPtr method_code; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006EF")]
	private IntPtr interp_method; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006F0")]
	private IntPtr interp_invoke_impl; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006F1")]
	private MethodInfo method_info; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006F2")]
	private MethodInfo original_method_info; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006F3")]
	private DelegateData data; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006F4")]
	private bool method_is_virtual; //Field offset: 0x70

	[Token(Token = "0x1700015D")]
	public MethodInfo Method
	{
		[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
		[Token(Token = "0x6000F88")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700015E")]
	public object Target
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000F8A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x207D230", Offset = "0x207C630", Length = "0x5")]
	[Token(Token = "0x6000FA9")]
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

	[Address(RVA = "0x207F830", Offset = "0x207EC30", Length = "0x170")]
	[Token(Token = "0x6000F8C")]
	private static bool arg_type_match(Type delArgType, Type argType) { }

	[Address(RVA = "0x207F9B0", Offset = "0x207EDB0", Length = "0x151")]
	[Token(Token = "0x6000F8D")]
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	[Address(RVA = "0x207D240", Offset = "0x207C640", Length = "0x5")]
	[Token(Token = "0x6000F9C")]
	public override object Clone() { }

	[Address(RVA = "0x207D410", Offset = "0x207C810", Length = "0x1BD")]
	[ComVisible(True)]
	[Token(Token = "0x6000FA3")]
	public static Delegate Combine(Delegate[] delegates) { }

	[Address(RVA = "0x207D2B0", Offset = "0x207C6B0", Length = "0x15F")]
	[Token(Token = "0x6000FA2")]
	public static Delegate Combine(Delegate a, Delegate b) { }

	[Address(RVA = "0x207D250", Offset = "0x207C650", Length = "0x55")]
	[Token(Token = "0x6000FA4")]
	protected override Delegate CombineImpl(Delegate d) { }

	[Address(RVA = "0x207E0D0", Offset = "0x207D4D0", Length = "0xED")]
	[Token(Token = "0x6000F97")]
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	[Address(RVA = "0x207E2A0", Offset = "0x207D6A0", Length = "0xEE")]
	[Token(Token = "0x6000F96")]
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	[Address(RVA = "0x207E3E0", Offset = "0x207D7E0", Length = "0x105")]
	[Token(Token = "0x6000F95")]
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	[Address(RVA = "0x207E1C0", Offset = "0x207D5C0", Length = "0xD7")]
	[Token(Token = "0x6000F93")]
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	[Address(RVA = "0x207D5E0", Offset = "0x207C9E0", Length = "0xE7")]
	[Token(Token = "0x6000F98")]
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	[Address(RVA = "0x207E390", Offset = "0x207D790", Length = "0x25")]
	[Token(Token = "0x6000F91")]
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	[Address(RVA = "0x207E3C0", Offset = "0x207D7C0", Length = "0x1F")]
	[Token(Token = "0x6000F90")]
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	[Address(RVA = "0x207D6D0", Offset = "0x207CAD0", Length = "0x9C1")]
	[Token(Token = "0x6000F8F")]
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	[Address(RVA = "0x207E0A0", Offset = "0x207D4A0", Length = "0x24")]
	[Token(Token = "0x6000F92")]
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	[Address(RVA = "0x207D5D0", Offset = "0x207C9D0", Length = "0x5")]
	[Token(Token = "0x6000F8B")]
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	[Address(RVA = "0x207E9C0", Offset = "0x207DDC0", Length = "0x14")]
	[Token(Token = "0x6000F99")]
	public object DynamicInvoke(Object[] args) { }

	[Address(RVA = "0x207E4F0", Offset = "0x207D8F0", Length = "0x4C5")]
	[Token(Token = "0x6000F9B")]
	protected override object DynamicInvokeImpl(Object[] args) { }

	[Address(RVA = "0x207E9E0", Offset = "0x207DDE0", Length = "0x1E1")]
	[Token(Token = "0x6000F9D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
	[Token(Token = "0x6000F88")]
	public MethodInfo get_Method() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000F8A")]
	public object get_Target() { }

	[Address(RVA = "0x207EBD0", Offset = "0x207DFD0", Length = "0x502")]
	[Token(Token = "0x6000F94")]
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	[Address(RVA = "0x207F0E0", Offset = "0x207E4E0", Length = "0x94")]
	[Token(Token = "0x6000F9E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x207F180", Offset = "0x207E580", Length = "0x9A")]
	[Token(Token = "0x6000FA1")]
	public override Delegate[] GetInvocationList() { }

	[Address(RVA = "0x207F220", Offset = "0x207E620", Length = "0x113")]
	[Token(Token = "0x6000F9F")]
	protected override MethodInfo GetMethodImpl() { }

	[Address(RVA = "0x207F340", Offset = "0x207E740", Length = "0x239")]
	[Token(Token = "0x6000FA0")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x207F580", Offset = "0x207E980", Length = "0x5")]
	[Token(Token = "0x6000F89")]
	private MethodInfo GetVirtualMethod_internal() { }

	[Address(RVA = "0x207F590", Offset = "0x207E990", Length = "0x101")]
	[Token(Token = "0x6000F9A")]
	private void InitializeDelegateData() { }

	[Address(RVA = "0x207FB10", Offset = "0x207EF10", Length = "0x28")]
	[Token(Token = "0x6000FA7")]
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	[Address(RVA = "0x207FB40", Offset = "0x207EF40", Length = "0x42")]
	[Token(Token = "0x6000FA8")]
	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	[Address(RVA = "0x207F6D0", Offset = "0x207EAD0", Length = "0x15E")]
	[Token(Token = "0x6000FA5")]
	public static Delegate Remove(Delegate source, Delegate value) { }

	[Address(RVA = "0x207F6A0", Offset = "0x207EAA0", Length = "0x2D")]
	[Token(Token = "0x6000FA6")]
	protected override Delegate RemoveImpl(Delegate d) { }

	[Address(RVA = "0x207FB90", Offset = "0x207EF90", Length = "0x200")]
	[Token(Token = "0x6000F8E")]
	private static bool return_type_match(Type delReturnType, Type returnType) { }

}

