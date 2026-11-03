namespace System;

[Token(Token = "0x2000146")]
public abstract class Type : MemberInfo
{
	[Token(Token = "0x400045C")]
	private static Binder s_defaultBinder; //Field offset: 0x0
	[Token(Token = "0x400045D")]
	public static readonly char Delimiter; //Field offset: 0x8
	[Token(Token = "0x400045E")]
	public static readonly Type[] EmptyTypes; //Field offset: 0x10
	[Token(Token = "0x400045F")]
	public static readonly object Missing; //Field offset: 0x18
	[Token(Token = "0x4000460")]
	public static readonly MemberFilter FilterAttribute; //Field offset: 0x20
	[Token(Token = "0x4000461")]
	public static readonly MemberFilter FilterName; //Field offset: 0x28
	[Token(Token = "0x4000462")]
	public static readonly MemberFilter FilterNameIgnoreCase; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000463")]
	internal RuntimeTypeHandle _impl; //Field offset: 0x10

	[Token(Token = "0x170000C0")]
	public abstract Assembly Assembly
	{
		[Token(Token = "0x6000ABB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BE")]
	public abstract string AssemblyQualifiedName
	{
		[Token(Token = "0x6000AB9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000D5")]
	public override TypeAttributes Attributes
	{
		[Address(RVA = "0x2053110", Offset = "0x2052510", Length = "0x14")]
		[Token(Token = "0x6000AD9")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000E9")]
	public abstract Type BaseType
	{
		[Token(Token = "0x6000B1B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BA")]
	public override bool ContainsGenericParameters
	{
		[Address(RVA = "0x2053130", Offset = "0x2052530", Length = "0x165")]
		[Token(Token = "0x6000AAC")]
		 get { } //Length: 357
	}

	[Token(Token = "0x170000C4")]
	public override MethodBase DeclaringMethod
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000ABF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C3")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000ABE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EA")]
	public static Binder DefaultBinder
	{
		[Address(RVA = "0x20532A0", Offset = "0x20526A0", Length = "0xD3")]
		[Token(Token = "0x6000B2C")]
		 get { } //Length: 211
	}

	[Token(Token = "0x170000BF")]
	public abstract string FullName
	{
		[Token(Token = "0x6000ABA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000ED")]
	internal string FullNameOrDefault
	{
		[Address(RVA = "0x2053380", Offset = "0x2052780", Length = "0x8B")]
		[Token(Token = "0x6000B3A")]
		internal get { } //Length: 139
	}

	[Token(Token = "0x170000D4")]
	public override GenericParameterAttributes GenericParameterAttributes
	{
		[Address(RVA = "0x2053410", Offset = "0x2052810", Length = "0x3E")]
		[Token(Token = "0x6000AD7")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170000D3")]
	public override int GenericParameterPosition
	{
		[Address(RVA = "0x2053450", Offset = "0x2052850", Length = "0x4E")]
		[Token(Token = "0x6000AD6")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000D2")]
	public override Type[] GenericTypeArguments
	{
		[Address(RVA = "0x20534A0", Offset = "0x20528A0", Length = "0x86")]
		[Token(Token = "0x6000AD4")]
		 get { } //Length: 134
	}

	[Token(Token = "0x170000E8")]
	public abstract Guid GUID
	{
		[Token(Token = "0x6000B19")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000D1")]
	public override bool HasElementType
	{
		[Address(RVA = "0x2053530", Offset = "0x2052930", Length = "0x14")]
		[Token(Token = "0x6000ACF")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000EE")]
	internal string InternalNameIfAvailable
	{
		[Address(RVA = "0x2053550", Offset = "0x2052950", Length = "0x2A")]
		[Token(Token = "0x6000B3D")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170000D6")]
	public override bool IsAbstract
	{
		[Address(RVA = "0x2053580", Offset = "0x2052980", Length = "0x24")]
		[Token(Token = "0x6000ADB")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000C7")]
	public override bool IsArray
	{
		[Address(RVA = "0x20535B0", Offset = "0x20529B0", Length = "0x14")]
		[Token(Token = "0x6000AC2")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000C8")]
	public override bool IsByRef
	{
		[Address(RVA = "0x20535D0", Offset = "0x20529D0", Length = "0x14")]
		[Token(Token = "0x6000AC4")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000D8")]
	public override bool IsClass
	{
		[Address(RVA = "0x2053610", Offset = "0x2052A10", Length = "0x49")]
		[Token(Token = "0x6000ADD")]
		 get { } //Length: 73
	}

	[Token(Token = "0x170000E1")]
	public override bool IsCollectible
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000AE8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000DF")]
	public override bool IsCOMObject
	{
		[Address(RVA = "0x20535F0", Offset = "0x20529F0", Length = "0x14")]
		[Token(Token = "0x6000AE4")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000CA")]
	public override bool IsConstructedGenericType
	{
		[Address(RVA = "0x2053660", Offset = "0x2052A60", Length = "0x27")]
		[Token(Token = "0x6000AC8")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170000E0")]
	public override bool IsContextful
	{
		[Address(RVA = "0x2053690", Offset = "0x2052A90", Length = "0x14")]
		[Token(Token = "0x6000AE6")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000E2")]
	public override bool IsEnum
	{
		[Address(RVA = "0x20536B0", Offset = "0x2052AB0", Length = "0x77")]
		[Token(Token = "0x6000AE9")]
		 get { } //Length: 119
	}

	[Token(Token = "0x170000DE")]
	public override bool IsExplicitLayout
	{
		[Address(RVA = "0x2053730", Offset = "0x2052B30", Length = "0x23")]
		[Token(Token = "0x6000AE3")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000CC")]
	public override bool IsGenericMethodParameter
	{
		[Address(RVA = "0x2053760", Offset = "0x2052B60", Length = "0x4E")]
		[Token(Token = "0x6000ACA")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000CB")]
	public override bool IsGenericParameter
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000AC9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000CD")]
	public override bool IsGenericType
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000ACB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000CE")]
	public override bool IsGenericTypeDefinition
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000ACC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EC")]
	public override bool IsInterface
	{
		[Address(RVA = "0x20537B0", Offset = "0x2052BB0", Length = "0xC4")]
		[Token(Token = "0x6000B32")]
		 get { } //Length: 196
	}

	[Token(Token = "0x170000E3")]
	public override bool IsMarshalByRef
	{
		[Address(RVA = "0x2053880", Offset = "0x2052C80", Length = "0x14")]
		[Token(Token = "0x6000AEA")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000C2")]
	public bool IsNested
	{
		[Address(RVA = "0x2053930", Offset = "0x2052D30", Length = "0x3D")]
		[Token(Token = "0x6000ABD")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170000D9")]
	public override bool IsNestedAssembly
	{
		[Address(RVA = "0x20538A0", Offset = "0x2052CA0", Length = "0x24")]
		[Token(Token = "0x6000ADE")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000DA")]
	public override bool IsNestedPrivate
	{
		[Address(RVA = "0x20538D0", Offset = "0x2052CD0", Length = "0x24")]
		[Token(Token = "0x6000ADF")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000DB")]
	public override bool IsNestedPublic
	{
		[Address(RVA = "0x2053900", Offset = "0x2052D00", Length = "0x23")]
		[Token(Token = "0x6000AE0")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000DC")]
	public override bool IsNotPublic
	{
		[Address(RVA = "0x2053970", Offset = "0x2052D70", Length = "0x21")]
		[Token(Token = "0x6000AE1")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170000C9")]
	public override bool IsPointer
	{
		[Address(RVA = "0x20539A0", Offset = "0x2052DA0", Length = "0x14")]
		[Token(Token = "0x6000AC6")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000E4")]
	public override bool IsPrimitive
	{
		[Address(RVA = "0x20539C0", Offset = "0x2052DC0", Length = "0x14")]
		[Token(Token = "0x6000AEC")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000DD")]
	public override bool IsPublic
	{
		[Address(RVA = "0x20539E0", Offset = "0x2052DE0", Length = "0x23")]
		[Token(Token = "0x6000AE2")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170000D7")]
	public override bool IsSealed
	{
		[Address(RVA = "0x2053A40", Offset = "0x2052E40", Length = "0x24")]
		[Token(Token = "0x6000ADC")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170000B9")]
	public override bool IsSerializable
	{
		[Address(RVA = "0x2053A70", Offset = "0x2052E70", Length = "0x16C")]
		[Token(Token = "0x6000AAB")]
		 get { } //Length: 364
	}

	[Token(Token = "0x170000E6")]
	public override bool IsSignatureType
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000AF0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000EB")]
	internal override bool IsSzArray
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B2F")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170000CF")]
	public override bool IsSZArray
	{
		[Address(RVA = "0x2053A10", Offset = "0x2052E10", Length = "0x27")]
		[Token(Token = "0x6000ACD")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170000E5")]
	public override bool IsValueType
	{
		[Address(RVA = "0x2053BE0", Offset = "0x2052FE0", Length = "0x14")]
		[Token(Token = "0x6000AEE")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000D0")]
	public override bool IsVariableBoundArray
	{
		[Address(RVA = "0x2053C00", Offset = "0x2053000", Length = "0x47")]
		[Token(Token = "0x6000ACE")]
		 get { } //Length: 71
	}

	[Token(Token = "0x170000BB")]
	public bool IsVisible
	{
		[Address(RVA = "0x2053C50", Offset = "0x2053050", Length = "0x1C7")]
		[Token(Token = "0x6000AAE")]
		 get { } //Length: 455
	}

	[Token(Token = "0x170000BC")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6000AB6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000C1")]
	public abstract Module Module
	{
		[Token(Token = "0x6000ABC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000EF")]
	internal string NameOrDefault
	{
		[Address(RVA = "0x2053E20", Offset = "0x2053220", Length = "0x60")]
		[Token(Token = "0x6000B3E")]
		internal get { } //Length: 96
	}

	[Token(Token = "0x170000BD")]
	public abstract string Namespace
	{
		[Token(Token = "0x6000AB8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C5")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000AC0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000E7")]
	public override RuntimeTypeHandle TypeHandle
	{
		[Address(RVA = "0x2053E80", Offset = "0x2053280", Length = "0x3E")]
		[Token(Token = "0x6000B15")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170000C6")]
	public abstract Type UnderlyingSystemType
	{
		[Token(Token = "0x6000AC1")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2052F20", Offset = "0x2052320", Length = "0x1EE")]
	[Token(Token = "0x6000B3F")]
	private static Type() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000AB5")]
	protected Type() { }

	[Address(RVA = "0x204F000", Offset = "0x204E400", Length = "0x19B")]
	[Token(Token = "0x6000AA9")]
	private static int BinarySearch(Array array, object value) { }

	[Address(RVA = "0x204F220", Offset = "0x204E620", Length = "0x64")]
	[Token(Token = "0x6000B29")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x204F1A0", Offset = "0x204E5A0", Length = "0x78")]
	[Token(Token = "0x6000B2B")]
	public override bool Equals(Type o) { }

	[Address(RVA = "0x204F290", Offset = "0x204E690", Length = "0x374")]
	[Token(Token = "0x6000AB2")]
	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria) { }

	[Address(RVA = "0x204F610", Offset = "0x204EA10", Length = "0x1AA")]
	[Token(Token = "0x6000AB4")]
	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria) { }

	[Address(RVA = "0x204F7C0", Offset = "0x204EBC0", Length = "0x19C")]
	[Token(Token = "0x6000AB3")]
	private static bool FilterNameImpl(MemberInfo m, object filterCriteria) { }

	[Address(RVA = "0x204F960", Offset = "0x204ED60", Length = "0x3E")]
	[Token(Token = "0x6000B31")]
	internal override string FormatTypeName(bool serialization) { }

	[Address(RVA = "0x204F9A0", Offset = "0x204EDA0", Length = "0x16")]
	[Token(Token = "0x6000B30")]
	internal string FormatTypeName() { }

	[Token(Token = "0x6000ABB")]
	public abstract Assembly get_Assembly() { }

	[Token(Token = "0x6000AB9")]
	public abstract string get_AssemblyQualifiedName() { }

	[Address(RVA = "0x2053110", Offset = "0x2052510", Length = "0x14")]
	[Token(Token = "0x6000AD9")]
	public override TypeAttributes get_Attributes() { }

	[Token(Token = "0x6000B1B")]
	public abstract Type get_BaseType() { }

	[Address(RVA = "0x2053130", Offset = "0x2052530", Length = "0x165")]
	[Token(Token = "0x6000AAC")]
	public override bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000ABF")]
	public override MethodBase get_DeclaringMethod() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000ABE")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x20532A0", Offset = "0x20526A0", Length = "0xD3")]
	[Token(Token = "0x6000B2C")]
	public static Binder get_DefaultBinder() { }

	[Token(Token = "0x6000ABA")]
	public abstract string get_FullName() { }

	[Address(RVA = "0x2053380", Offset = "0x2052780", Length = "0x8B")]
	[Token(Token = "0x6000B3A")]
	internal string get_FullNameOrDefault() { }

	[Address(RVA = "0x2053410", Offset = "0x2052810", Length = "0x3E")]
	[Token(Token = "0x6000AD7")]
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	[Address(RVA = "0x2053450", Offset = "0x2052850", Length = "0x4E")]
	[Token(Token = "0x6000AD6")]
	public override int get_GenericParameterPosition() { }

	[Address(RVA = "0x20534A0", Offset = "0x20528A0", Length = "0x86")]
	[Token(Token = "0x6000AD4")]
	public override Type[] get_GenericTypeArguments() { }

	[Token(Token = "0x6000B19")]
	public abstract Guid get_GUID() { }

	[Address(RVA = "0x2053530", Offset = "0x2052930", Length = "0x14")]
	[Token(Token = "0x6000ACF")]
	public override bool get_HasElementType() { }

	[Address(RVA = "0x2053550", Offset = "0x2052950", Length = "0x2A")]
	[Token(Token = "0x6000B3D")]
	internal string get_InternalNameIfAvailable() { }

	[Address(RVA = "0x2053580", Offset = "0x2052980", Length = "0x24")]
	[Token(Token = "0x6000ADB")]
	public override bool get_IsAbstract() { }

	[Address(RVA = "0x20535B0", Offset = "0x20529B0", Length = "0x14")]
	[Token(Token = "0x6000AC2")]
	public override bool get_IsArray() { }

	[Address(RVA = "0x20535D0", Offset = "0x20529D0", Length = "0x14")]
	[Token(Token = "0x6000AC4")]
	public override bool get_IsByRef() { }

	[Address(RVA = "0x2053610", Offset = "0x2052A10", Length = "0x49")]
	[Token(Token = "0x6000ADD")]
	public override bool get_IsClass() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000AE8")]
	public override bool get_IsCollectible() { }

	[Address(RVA = "0x20535F0", Offset = "0x20529F0", Length = "0x14")]
	[Token(Token = "0x6000AE4")]
	public override bool get_IsCOMObject() { }

	[Address(RVA = "0x2053660", Offset = "0x2052A60", Length = "0x27")]
	[Token(Token = "0x6000AC8")]
	public override bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x2053690", Offset = "0x2052A90", Length = "0x14")]
	[Token(Token = "0x6000AE6")]
	public override bool get_IsContextful() { }

	[Address(RVA = "0x20536B0", Offset = "0x2052AB0", Length = "0x77")]
	[Token(Token = "0x6000AE9")]
	public override bool get_IsEnum() { }

	[Address(RVA = "0x2053730", Offset = "0x2052B30", Length = "0x23")]
	[Token(Token = "0x6000AE3")]
	public override bool get_IsExplicitLayout() { }

	[Address(RVA = "0x2053760", Offset = "0x2052B60", Length = "0x4E")]
	[Token(Token = "0x6000ACA")]
	public override bool get_IsGenericMethodParameter() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AC9")]
	public override bool get_IsGenericParameter() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000ACB")]
	public override bool get_IsGenericType() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000ACC")]
	public override bool get_IsGenericTypeDefinition() { }

	[Address(RVA = "0x20537B0", Offset = "0x2052BB0", Length = "0xC4")]
	[Token(Token = "0x6000B32")]
	public override bool get_IsInterface() { }

	[Address(RVA = "0x2053880", Offset = "0x2052C80", Length = "0x14")]
	[Token(Token = "0x6000AEA")]
	public override bool get_IsMarshalByRef() { }

	[Address(RVA = "0x2053930", Offset = "0x2052D30", Length = "0x3D")]
	[Token(Token = "0x6000ABD")]
	public bool get_IsNested() { }

	[Address(RVA = "0x20538A0", Offset = "0x2052CA0", Length = "0x24")]
	[Token(Token = "0x6000ADE")]
	public override bool get_IsNestedAssembly() { }

	[Address(RVA = "0x20538D0", Offset = "0x2052CD0", Length = "0x24")]
	[Token(Token = "0x6000ADF")]
	public override bool get_IsNestedPrivate() { }

	[Address(RVA = "0x2053900", Offset = "0x2052D00", Length = "0x23")]
	[Token(Token = "0x6000AE0")]
	public override bool get_IsNestedPublic() { }

	[Address(RVA = "0x2053970", Offset = "0x2052D70", Length = "0x21")]
	[Token(Token = "0x6000AE1")]
	public override bool get_IsNotPublic() { }

	[Address(RVA = "0x20539A0", Offset = "0x2052DA0", Length = "0x14")]
	[Token(Token = "0x6000AC6")]
	public override bool get_IsPointer() { }

	[Address(RVA = "0x20539C0", Offset = "0x2052DC0", Length = "0x14")]
	[Token(Token = "0x6000AEC")]
	public override bool get_IsPrimitive() { }

	[Address(RVA = "0x20539E0", Offset = "0x2052DE0", Length = "0x23")]
	[Token(Token = "0x6000AE2")]
	public override bool get_IsPublic() { }

	[Address(RVA = "0x2053A40", Offset = "0x2052E40", Length = "0x24")]
	[Token(Token = "0x6000ADC")]
	public override bool get_IsSealed() { }

	[Address(RVA = "0x2053A70", Offset = "0x2052E70", Length = "0x16C")]
	[Token(Token = "0x6000AAB")]
	public override bool get_IsSerializable() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000AF0")]
	public override bool get_IsSignatureType() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B2F")]
	internal override bool get_IsSzArray() { }

	[Address(RVA = "0x2053A10", Offset = "0x2052E10", Length = "0x27")]
	[Token(Token = "0x6000ACD")]
	public override bool get_IsSZArray() { }

	[Address(RVA = "0x2053BE0", Offset = "0x2052FE0", Length = "0x14")]
	[Token(Token = "0x6000AEE")]
	public override bool get_IsValueType() { }

	[Address(RVA = "0x2053C00", Offset = "0x2053000", Length = "0x47")]
	[Token(Token = "0x6000ACE")]
	public override bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x2053C50", Offset = "0x2053050", Length = "0x1C7")]
	[Token(Token = "0x6000AAE")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6000AB6")]
	public virtual MemberTypes get_MemberType() { }

	[Token(Token = "0x6000ABC")]
	public abstract Module get_Module() { }

	[Address(RVA = "0x2053E20", Offset = "0x2053220", Length = "0x60")]
	[Token(Token = "0x6000B3E")]
	internal string get_NameOrDefault() { }

	[Token(Token = "0x6000AB8")]
	public abstract string get_Namespace() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AC0")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x2053E80", Offset = "0x2053280", Length = "0x3E")]
	[Token(Token = "0x6000B15")]
	public override RuntimeTypeHandle get_TypeHandle() { }

	[Token(Token = "0x6000AC1")]
	public abstract Type get_UnderlyingSystemType() { }

	[Address(RVA = "0x204F9C0", Offset = "0x204EDC0", Length = "0x4E")]
	[Token(Token = "0x6000AD2")]
	public override int GetArrayRank() { }

	[Token(Token = "0x6000ADA")]
	protected abstract TypeAttributes GetAttributeFlagsImpl() { }

	[Address(RVA = "0x204FA10", Offset = "0x204EE10", Length = "0x167")]
	[ComVisible(True)]
	[Token(Token = "0x6000AF2")]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x204FB80", Offset = "0x204EF80", Length = "0x15E")]
	[ComVisible(True)]
	[Token(Token = "0x6000AF3")]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x204FCE0", Offset = "0x204F0E0", Length = "0x154")]
	[ComVisible(True)]
	[Token(Token = "0x6000AF1")]
	public override ConstructorInfo GetConstructor(Type[] types) { }

	[Token(Token = "0x6000AF4")]
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x204FE40", Offset = "0x204F240", Length = "0x19")]
	[ComVisible(True)]
	[Token(Token = "0x6000AF5")]
	public override ConstructorInfo[] GetConstructors() { }

	[ComVisible(True)]
	[Token(Token = "0x6000AF6")]
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[Token(Token = "0x6000AD1")]
	public abstract Type GetElementType() { }

	[Address(RVA = "0x204FE60", Offset = "0x204F260", Length = "0x448")]
	[Token(Token = "0x6000AA8")]
	private void GetEnumData(out String[] enumNames, out Array enumValues) { }

	[Address(RVA = "0x20502B0", Offset = "0x204F6B0", Length = "0x3AF")]
	[Token(Token = "0x6000AA5")]
	public override string GetEnumName(object value) { }

	[Address(RVA = "0x2050660", Offset = "0x204FA60", Length = "0xB0")]
	[Token(Token = "0x6000AA6")]
	public override String[] GetEnumNames() { }

	[Address(RVA = "0x2050710", Offset = "0x204FB10", Length = "0x2C")]
	[Token(Token = "0x6000AA7")]
	private Array GetEnumRawConstantValues() { }

	[Address(RVA = "0x2050740", Offset = "0x204FB40", Length = "0x144")]
	[Token(Token = "0x6000B20")]
	public override Type GetEnumUnderlyingType() { }

	[Address(RVA = "0x2050890", Offset = "0x204FC90", Length = "0xA3")]
	[Token(Token = "0x6000B21")]
	public override Array GetEnumValues() { }

	[Token(Token = "0x6000AF8")]
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2050940", Offset = "0x204FD40", Length = "0x1A")]
	[Token(Token = "0x6000AF7")]
	public override EventInfo GetEvent(string name) { }

	[Token(Token = "0x6000AF9")]
	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[Token(Token = "0x6000AFB")]
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2050960", Offset = "0x204FD60", Length = "0x1A")]
	[Token(Token = "0x6000AFA")]
	public override FieldInfo GetField(string name) { }

	[Address(RVA = "0x2050980", Offset = "0x204FD80", Length = "0x19")]
	[Token(Token = "0x6000AFC")]
	public override FieldInfo[] GetFields() { }

	[Token(Token = "0x6000AFD")]
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[Address(RVA = "0x20509A0", Offset = "0x204FDA0", Length = "0x4E")]
	[Token(Token = "0x6000AD5")]
	public override Type[] GetGenericArguments() { }

	[Address(RVA = "0x20509F0", Offset = "0x204FDF0", Length = "0x97")]
	[Token(Token = "0x6000AD8")]
	public override Type[] GetGenericParameterConstraints() { }

	[Address(RVA = "0x2050A90", Offset = "0x204FE90", Length = "0x4E")]
	[Token(Token = "0x6000AD3")]
	public override Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x2050AE0", Offset = "0x204FEE0", Length = "0x56")]
	[Token(Token = "0x6000B2A")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6000B1D")]
	public abstract Type[] GetInterfaces() { }

	[Address(RVA = "0x2050B40", Offset = "0x204FF40", Length = "0x2B")]
	[Token(Token = "0x6000AFF")]
	public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2050B90", Offset = "0x204FF90", Length = "0x4E")]
	[Token(Token = "0x6000B00")]
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2050B70", Offset = "0x204FF70", Length = "0x1A")]
	[Token(Token = "0x6000AFE")]
	public override MemberInfo[] GetMember(string name) { }

	[Token(Token = "0x6000B01")]
	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[Address(RVA = "0x2050D90", Offset = "0x2050190", Length = "0x96")]
	[Token(Token = "0x6000B02")]
	public override MethodInfo GetMethod(string name) { }

	[Address(RVA = "0x2050E30", Offset = "0x2050230", Length = "0x90")]
	[Token(Token = "0x6000B03")]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2050EC0", Offset = "0x20502C0", Length = "0x1A7")]
	[Token(Token = "0x6000B04")]
	public override MethodInfo GetMethod(string name, Type[] types) { }

	[Address(RVA = "0x2050BE0", Offset = "0x204FFE0", Length = "0x1AD")]
	[Token(Token = "0x6000B05")]
	public override MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2051240", Offset = "0x2050640", Length = "0x1B9")]
	[Token(Token = "0x6000B06")]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2051070", Offset = "0x2050470", Length = "0x1C7")]
	[Token(Token = "0x6000B07")]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Token(Token = "0x6000B08")]
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[Token(Token = "0x6000B0A")]
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[Address(RVA = "0x2051400", Offset = "0x2050800", Length = "0x19")]
	[Token(Token = "0x6000B09")]
	public override MethodInfo[] GetMethods() { }

	[Token(Token = "0x6000B0B")]
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr) { }

	[Token(Token = "0x6000B14")]
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[Address(RVA = "0x2051420", Offset = "0x2050820", Length = "0x19")]
	[Token(Token = "0x6000B13")]
	public override PropertyInfo[] GetProperties() { }

	[Address(RVA = "0x2051610", Offset = "0x2050A10", Length = "0xEC")]
	[Token(Token = "0x6000B11")]
	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2051790", Offset = "0x2050B90", Length = "0x93")]
	[Token(Token = "0x6000B0C")]
	public override PropertyInfo GetProperty(string name) { }

	[Address(RVA = "0x2051530", Offset = "0x2050930", Length = "0xD7")]
	[Token(Token = "0x6000B0F")]
	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	[Address(RVA = "0x2051700", Offset = "0x2050B00", Length = "0x8D")]
	[Token(Token = "0x6000B0D")]
	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	[Address(RVA = "0x2051440", Offset = "0x2050840", Length = "0xE1")]
	[Token(Token = "0x6000B10")]
	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2051830", Offset = "0x2050C30", Length = "0x115")]
	[Token(Token = "0x6000B0E")]
	public override PropertyInfo GetProperty(string name, Type returnType) { }

	[Token(Token = "0x6000B12")]
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[Address(RVA = "0x2051950", Offset = "0x2050D50", Length = "0x5D")]
	[Token(Token = "0x6000AAD")]
	internal Type GetRootElementType() { }

	[Address(RVA = "0x2051DB0", Offset = "0x20511B0", Length = "0x88")]
	[Token(Token = "0x6000B33")]
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	[Address(RVA = "0x2051CC0", Offset = "0x20510C0", Length = "0x78")]
	[Token(Token = "0x6000B34")]
	public static Type GetType(string typeName, bool throwOnError) { }

	[Address(RVA = "0x2051D40", Offset = "0x2051140", Length = "0x6B")]
	[Token(Token = "0x6000B35")]
	public static Type GetType(string typeName) { }

	[Address(RVA = "0x2051E50", Offset = "0x2051250", Length = "0x2E")]
	[Token(Token = "0x6000B36")]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError) { }

	[Address(RVA = "0x2051E40", Offset = "0x2051240", Length = "0x7")]
	[Token(Token = "0x6000AB7")]
	public override Type GetType() { }

	[Address(RVA = "0x2051AB0", Offset = "0x2050EB0", Length = "0x47")]
	[Token(Token = "0x6000B17")]
	public static TypeCode GetTypeCode(Type type) { }

	[Address(RVA = "0x20519B0", Offset = "0x2050DB0", Length = "0xFA")]
	[Token(Token = "0x6000B18")]
	protected override TypeCode GetTypeCodeImpl() { }

	[Address(RVA = "0x2051B70", Offset = "0x2050F70", Length = "0x76")]
	[Token(Token = "0x6000B39")]
	public static Type GetTypeFromCLSID(Guid clsid, string server, bool throwOnError) { }

	[Address(RVA = "0x2051B00", Offset = "0x2050F00", Length = "0x6F")]
	[Token(Token = "0x6000B1A")]
	public static Type GetTypeFromCLSID(Guid clsid) { }

	[Address(RVA = "0x2051BF0", Offset = "0x2050FF0", Length = "0x38")]
	[Token(Token = "0x6000B2D")]
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	[Address(RVA = "0x2051C30", Offset = "0x2051030", Length = "0x89")]
	[Token(Token = "0x6000B16")]
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	[Token(Token = "0x6000AD0")]
	protected abstract bool HasElementTypeImpl() { }

	[Address(RVA = "0x2051E80", Offset = "0x2051280", Length = "0x11C")]
	[Token(Token = "0x6000AB1")]
	internal bool ImplementInterface(Type ifaceType) { }

	[Address(RVA = "0x2053EC0", Offset = "0x20532C0", Length = "0x5")]
	[Token(Token = "0x6000B2E")]
	private static Type internal_from_handle(IntPtr handle) { }

	[Address(RVA = "0x2051FA0", Offset = "0x20513A0", Length = "0x14")]
	[Token(Token = "0x6000B3C")]
	internal override string InternalGetNameIfAvailable(ref Type rootCauseForFailure) { }

	[Token(Token = "0x6000B1C")]
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	[Token(Token = "0x6000AC3")]
	protected abstract bool IsArrayImpl() { }

	[Address(RVA = "0x2051FC0", Offset = "0x20513C0", Length = "0x18A")]
	[Token(Token = "0x6000AB0")]
	public override bool IsAssignableFrom(Type c) { }

	[Token(Token = "0x6000AC5")]
	protected abstract bool IsByRefImpl() { }

	[Token(Token = "0x6000AE5")]
	protected abstract bool IsCOMObjectImpl() { }

	[Address(RVA = "0x2052150", Offset = "0x2051550", Length = "0x95")]
	[Token(Token = "0x6000AE7")]
	protected override bool IsContextfulImpl() { }

	[Address(RVA = "0x20521F0", Offset = "0x20515F0", Length = "0x5A5")]
	[Token(Token = "0x6000AA4")]
	public override bool IsEnumDefined(object value) { }

	[Address(RVA = "0x20527A0", Offset = "0x2051BA0", Length = "0x36")]
	[Token(Token = "0x6000B1F")]
	public override bool IsEquivalentTo(Type other) { }

	[Address(RVA = "0x20527E0", Offset = "0x2051BE0", Length = "0x40")]
	[Token(Token = "0x6000B1E")]
	public override bool IsInstanceOfType(object o) { }

	[Address(RVA = "0x2052820", Offset = "0x2051C20", Length = "0x282")]
	[Token(Token = "0x6000AAA")]
	internal static bool IsIntegerType(Type t) { }

	[Address(RVA = "0x2052AB0", Offset = "0x2051EB0", Length = "0x95")]
	[Token(Token = "0x6000AEB")]
	protected override bool IsMarshalByRefImpl() { }

	[Token(Token = "0x6000AC7")]
	protected abstract bool IsPointerImpl() { }

	[Token(Token = "0x6000AED")]
	protected abstract bool IsPrimitiveImpl() { }

	[Address(RVA = "0x2052B50", Offset = "0x2051F50", Length = "0x8A")]
	[Token(Token = "0x6000B3B")]
	internal bool IsRuntimeImplemented() { }

	[Address(RVA = "0x2052BE0", Offset = "0x2051FE0", Length = "0x99")]
	[ComVisible(True)]
	[Token(Token = "0x6000AAF")]
	public override bool IsSubclassOf(Type c) { }

	[Address(RVA = "0x2052C80", Offset = "0x2052080", Length = "0x77")]
	[Token(Token = "0x6000AEF")]
	protected override bool IsValueTypeImpl() { }

	[Address(RVA = "0x2052D40", Offset = "0x2052140", Length = "0x3E")]
	[Token(Token = "0x6000B23")]
	public override Type MakeArrayType(int rank) { }

	[Address(RVA = "0x2052D00", Offset = "0x2052100", Length = "0x3E")]
	[Token(Token = "0x6000B22")]
	public override Type MakeArrayType() { }

	[Address(RVA = "0x2052D80", Offset = "0x2052180", Length = "0x3E")]
	[Token(Token = "0x6000B24")]
	public override Type MakeByRefType() { }

	[Address(RVA = "0x2052DC0", Offset = "0x20521C0", Length = "0x64")]
	[Token(Token = "0x6000B27")]
	public static Type MakeGenericSignatureType(Type genericTypeDefinition, Type[] typeArguments) { }

	[Address(RVA = "0x2052E30", Offset = "0x2052230", Length = "0x4E")]
	[Token(Token = "0x6000B25")]
	public override Type MakeGenericType(Type[] typeArguments) { }

	[Address(RVA = "0x2052E80", Offset = "0x2052280", Length = "0x3E")]
	[Token(Token = "0x6000B26")]
	public override Type MakePointerType() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000B37")]
	public static bool op_Equality(Type left, Type right) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000B38")]
	public static bool op_Inequality(Type left, Type right) { }

	[Address(RVA = "0x2052EC0", Offset = "0x20522C0", Length = "0x52")]
	[Token(Token = "0x6000B28")]
	public virtual string ToString() { }

}

