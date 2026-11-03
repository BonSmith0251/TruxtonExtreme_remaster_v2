namespace System.Reflection;

[Token(Token = "0x20004FD")]
internal abstract class SignatureHasElementType : SignatureType
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013AC")]
	private readonly SignatureType _elementType; //Field offset: 0x18

	[Token(Token = "0x1700046F")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x1F6B950", Offset = "0x1F6AD50", Length = "0x2A")]
		[Token(Token = "0x6002308")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000470")]
	internal virtual SignatureType ElementType
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6002309")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000472")]
	public virtual int GenericParameterPosition
	{
		[Address(RVA = "0x1F6B980", Offset = "0x1F6AD80", Length = "0x4E")]
		[Token(Token = "0x600230E")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000471")]
	public virtual Type[] GenericTypeArguments
	{
		[Address(RVA = "0x1F6B9D0", Offset = "0x1F6ADD0", Length = "0x30")]
		[Token(Token = "0x600230D")]
		 get { } //Length: 48
	}

	[Token(Token = "0x1700046C")]
	public virtual bool IsConstructedGenericType
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002305")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700046E")]
	public virtual bool IsGenericMethodParameter
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002307")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700046D")]
	public virtual bool IsGenericParameter
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002306")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000469")]
	public virtual bool IsGenericTypeDefinition
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60022FE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700046A")]
	public abstract bool IsSZArray
	{
		[Token(Token = "0x6002303")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700046B")]
	public abstract bool IsVariableBoundArray
	{
		[Token(Token = "0x6002304")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000473")]
	public virtual string Name
	{
		[Address(RVA = "0x1F6BA00", Offset = "0x1F6AE00", Length = "0x61")]
		[Token(Token = "0x600230F")]
		 get { } //Length: 97
	}

	[Token(Token = "0x17000474")]
	public virtual string Namespace
	{
		[Address(RVA = "0x1F6B830", Offset = "0x1F6AC30", Length = "0x2A")]
		[Token(Token = "0x6002310")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000475")]
	protected abstract string Suffix
	{
		[Token(Token = "0x6002312")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1F6B200", Offset = "0x1F6A600", Length = "0x49")]
	[Token(Token = "0x60022FD")]
	protected SignatureHasElementType(SignatureType elementType) { }

	[Address(RVA = "0x1F6B950", Offset = "0x1F6AD50", Length = "0x2A")]
	[Token(Token = "0x6002308")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6002309")]
	internal virtual SignatureType get_ElementType() { }

	[Address(RVA = "0x1F6B980", Offset = "0x1F6AD80", Length = "0x4E")]
	[Token(Token = "0x600230E")]
	public virtual int get_GenericParameterPosition() { }

	[Address(RVA = "0x1F6B9D0", Offset = "0x1F6ADD0", Length = "0x30")]
	[Token(Token = "0x600230D")]
	public virtual Type[] get_GenericTypeArguments() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002305")]
	public virtual bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002307")]
	public virtual bool get_IsGenericMethodParameter() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002306")]
	public virtual bool get_IsGenericParameter() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60022FE")]
	public virtual bool get_IsGenericTypeDefinition() { }

	[Token(Token = "0x6002303")]
	public abstract bool get_IsSZArray() { }

	[Token(Token = "0x6002304")]
	public abstract bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x1F6BA00", Offset = "0x1F6AE00", Length = "0x61")]
	[Token(Token = "0x600230F")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F6B830", Offset = "0x1F6AC30", Length = "0x2A")]
	[Token(Token = "0x6002310")]
	public virtual string get_Namespace() { }

	[Token(Token = "0x6002312")]
	protected abstract string get_Suffix() { }

	[Token(Token = "0x600230A")]
	public abstract int GetArrayRank() { }

	[Address(RVA = "0x1F6B860", Offset = "0x1F6AC60", Length = "0x30")]
	[Token(Token = "0x600230C")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x1F6B890", Offset = "0x1F6AC90", Length = "0x4E")]
	[Token(Token = "0x600230B")]
	public virtual Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60022FF")]
	protected virtual bool HasElementTypeImpl() { }

	[Token(Token = "0x6002300")]
	protected abstract bool IsArrayImpl() { }

	[Token(Token = "0x6002301")]
	protected abstract bool IsByRefImpl() { }

	[Token(Token = "0x6002302")]
	protected abstract bool IsPointerImpl() { }

	[Address(RVA = "0x1F6B8E0", Offset = "0x1F6ACE0", Length = "0x61")]
	[Token(Token = "0x6002311")]
	public virtual string ToString() { }

}

