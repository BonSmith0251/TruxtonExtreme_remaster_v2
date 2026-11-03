namespace System.Reflection;

[Token(Token = "0x20004FC")]
internal sealed class SignatureConstructedGenericType : SignatureType
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013AA")]
	private readonly Type _genericTypeDefinition; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013AB")]
	private readonly Type[] _genericTypeArguments; //Field offset: 0x20

	[Token(Token = "0x17000463")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x1F6B690", Offset = "0x1F6AA90", Length = "0x99")]
		[Token(Token = "0x60022F3")]
		 get { } //Length: 153
	}

	[Token(Token = "0x17000464")]
	internal virtual SignatureType ElementType
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60022F4")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000466")]
	public virtual int GenericParameterPosition
	{
		[Address(RVA = "0x1F6B730", Offset = "0x1F6AB30", Length = "0x4E")]
		[Token(Token = "0x60022F9")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000465")]
	public virtual Type[] GenericTypeArguments
	{
		[Address(RVA = "0x1F6B780", Offset = "0x1F6AB80", Length = "0x77")]
		[Token(Token = "0x60022F8")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000460")]
	public virtual bool IsConstructedGenericType
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60022F0")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000462")]
	public virtual bool IsGenericMethodParameter
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022F2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000461")]
	public virtual bool IsGenericParameter
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022F1")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700045D")]
	public virtual bool IsGenericTypeDefinition
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022E9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700045E")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022EE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700045F")]
	public virtual bool IsVariableBoundArray
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022EF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000467")]
	public virtual string Name
	{
		[Address(RVA = "0x1F6B800", Offset = "0x1F6AC00", Length = "0x2A")]
		[Token(Token = "0x60022FA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000468")]
	public virtual string Namespace
	{
		[Address(RVA = "0x1F6B830", Offset = "0x1F6AC30", Length = "0x2A")]
		[Token(Token = "0x60022FB")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1F6B450", Offset = "0x1F6A850", Length = "0x23D")]
	[Token(Token = "0x60022E8")]
	internal SignatureConstructedGenericType(Type genericTypeDefinition, Type[] typeArguments) { }

	[Address(RVA = "0x1F6B690", Offset = "0x1F6AA90", Length = "0x99")]
	[Token(Token = "0x60022F3")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60022F4")]
	internal virtual SignatureType get_ElementType() { }

	[Address(RVA = "0x1F6B730", Offset = "0x1F6AB30", Length = "0x4E")]
	[Token(Token = "0x60022F9")]
	public virtual int get_GenericParameterPosition() { }

	[Address(RVA = "0x1F6B780", Offset = "0x1F6AB80", Length = "0x77")]
	[Token(Token = "0x60022F8")]
	public virtual Type[] get_GenericTypeArguments() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60022F0")]
	public virtual bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022F2")]
	public virtual bool get_IsGenericMethodParameter() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022F1")]
	public virtual bool get_IsGenericParameter() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022E9")]
	public virtual bool get_IsGenericTypeDefinition() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022EE")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022EF")]
	public virtual bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x1F6B800", Offset = "0x1F6AC00", Length = "0x2A")]
	[Token(Token = "0x60022FA")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F6B830", Offset = "0x1F6AC30", Length = "0x2A")]
	[Token(Token = "0x60022FB")]
	public virtual string get_Namespace() { }

	[Address(RVA = "0x1F6B280", Offset = "0x1F6A680", Length = "0x4E")]
	[Token(Token = "0x60022F5")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x1F6B2D0", Offset = "0x1F6A6D0", Length = "0x14")]
	[Token(Token = "0x60022F7")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60022F6")]
	public virtual Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022EA")]
	protected virtual bool HasElementTypeImpl() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022EB")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022EC")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022ED")]
	protected virtual bool IsPointerImpl() { }

	[Address(RVA = "0x1F6B2F0", Offset = "0x1F6A6F0", Length = "0x15A")]
	[Token(Token = "0x60022FC")]
	public virtual string ToString() { }

}

