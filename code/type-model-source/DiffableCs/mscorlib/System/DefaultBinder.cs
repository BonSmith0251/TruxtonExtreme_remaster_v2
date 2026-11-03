namespace System;

[Token(Token = "0x2000184")]
internal class DefaultBinder : Binder
{
	[CompilerGenerated]
	[Token(Token = "0x2000187")]
	private sealed class <>c
	{
		[Token(Token = "0x4000597")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000598")]
		public static Predicate<Type> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x20796F0", Offset = "0x2078AF0", Length = "0xB2")]
		[Token(Token = "0x6000DDF")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000DE0")]
		public <>c() { }

		[Address(RVA = "0x20796C0", Offset = "0x2078AC0", Length = "0x30")]
		[Token(Token = "0x6000DE1")]
		internal bool <SelectProperty>b__2_0(Type t) { }

	}

	[Token(Token = "0x2000185")]
	public class BinderState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000584")]
		internal Int32[] m_argsMap; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000585")]
		internal int m_originalSize; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000586")]
		internal bool m_isParamArray; //Field offset: 0x1C

		[Address(RVA = "0x205C4E0", Offset = "0x205B8E0", Length = "0x54")]
		[Token(Token = "0x6000DDE")]
		internal BinderState(Int32[] argsMap, int originalSize, bool isParamArray) { }

	}

	[Flags]
	[Token(Token = "0x2000186")]
	private enum Primitives : int
	{
		Boolean = 8,
		Char = 16,
		SByte = 32,
		Byte = 64,
		Int16 = 128,
		UInt16 = 256,
		Int32 = 512,
		UInt32 = 1024,
		Int64 = 2048,
		UInt64 = 4096,
		Single = 8192,
		Double = 16384,
		Decimal = 32768,
		DateTime = 65536,
		String = 262144,
	}

	[Token(Token = "0x4000583")]
	private static Primitives[] _primitiveConversions; //Field offset: 0x0

	[Address(RVA = "0x20635E0", Offset = "0x20629E0", Length = "0x8C")]
	[Token(Token = "0x6000DDD")]
	private static DefaultBinder() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000DDC")]
	public DefaultBinder() { }

	[Address(RVA = "0x205CFF0", Offset = "0x205C3F0", Length = "0x6F2")]
	[Token(Token = "0x6000DC6")]
	public virtual FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	[Address(RVA = "0x205D6F0", Offset = "0x205CAF0", Length = "0x26DD")]
	[Token(Token = "0x6000DC5")]
	public virtual MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref Object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, String[] names, out object state) { }

	[Address(RVA = "0x205FDD0", Offset = "0x205F1D0", Length = "0xEE")]
	[Token(Token = "0x6000DDA")]
	private static bool CanChangePrimitive(Type source, Type target) { }

	[Address(RVA = "0x205FFD0", Offset = "0x205F3D0", Length = "0xBC")]
	[Token(Token = "0x6000DD6")]
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	[Address(RVA = "0x205FEC0", Offset = "0x205F2C0", Length = "0x102")]
	[Token(Token = "0x6000DD7")]
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	[Address(RVA = "0x2060220", Offset = "0x205F620", Length = "0xC0")]
	[Token(Token = "0x6000DDB")]
	private static bool CanPrimitiveWiden(Type source, Type target) { }

	[Address(RVA = "0x20602F0", Offset = "0x205F6F0", Length = "0x5F")]
	[Token(Token = "0x6000DC8")]
	public virtual object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	[Address(RVA = "0x2060350", Offset = "0x205F750", Length = "0x162")]
	[Token(Token = "0x6000DD8")]
	internal static bool CompareMethodSig(MethodBase m1, MethodBase m2) { }

	[Address(RVA = "0x2060350", Offset = "0x205F750", Length = "0x162")]
	[Token(Token = "0x6000DD1")]
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	[Address(RVA = "0x20604C0", Offset = "0x205F8C0", Length = "0x234")]
	[Token(Token = "0x6000DD5")]
	private static bool CreateParamOrder(Int32[] paramOrder, ParameterInfo[] pars, String[] names) { }

	[Address(RVA = "0x2060700", Offset = "0x205FB00", Length = "0x2C0")]
	[Token(Token = "0x6000DCA")]
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x20609D0", Offset = "0x205FDD0", Length = "0x2F7")]
	[Token(Token = "0x6000DCB")]
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2060CD0", Offset = "0x20600D0", Length = "0x19B")]
	[Token(Token = "0x6000DD3")]
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	[Address(RVA = "0x20617A0", Offset = "0x2060BA0", Length = "0x437")]
	[Token(Token = "0x6000DCC")]
	private static int FindMostSpecific(ParameterInfo[] p1, Int32[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	[Address(RVA = "0x2060E70", Offset = "0x2060270", Length = "0x116")]
	[Token(Token = "0x6000DCF")]
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	[Address(RVA = "0x2060F90", Offset = "0x2060390", Length = "0x2D4")]
	[Token(Token = "0x6000DCE")]
	private static int FindMostSpecificMethod(MethodBase m1, Int32[] paramOrder1, Type paramArrayType1, MethodBase m2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	[Address(RVA = "0x2061270", Offset = "0x2060670", Length = "0x116")]
	[Token(Token = "0x6000DD0")]
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	[Address(RVA = "0x2061390", Offset = "0x2060790", Length = "0x403")]
	[Token(Token = "0x6000DCD")]
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	[Address(RVA = "0x2061BE0", Offset = "0x2060FE0", Length = "0x68")]
	[Token(Token = "0x6000DD2")]
	internal static int GetHierarchyDepth(Type t) { }

	[Address(RVA = "0x2061C50", Offset = "0x2061050", Length = "0x385")]
	[Token(Token = "0x6000DC9")]
	public virtual void ReorderArgumentArray(ref Object[] args, object state) { }

	[Address(RVA = "0x2061FE0", Offset = "0x20613E0", Length = "0x1A3")]
	[Token(Token = "0x6000DD4")]
	private static void ReorderParams(Int32[] paramOrder, Object[] vars) { }

	[Address(RVA = "0x2062190", Offset = "0x2061590", Length = "0x8A9")]
	[Token(Token = "0x6000DD9")]
	public virtual MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2062A40", Offset = "0x2061E40", Length = "0xB91")]
	[Token(Token = "0x6000DC7")]
	public virtual PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

