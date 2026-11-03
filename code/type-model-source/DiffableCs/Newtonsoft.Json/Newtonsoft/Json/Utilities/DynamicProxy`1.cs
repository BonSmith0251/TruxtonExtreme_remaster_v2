namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000AB")]
internal class DynamicProxy
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60005B1")]
	public DynamicProxy`1() { }

	[Address(RVA = "0x1951000", Offset = "0x1950400", Length = "0x30")]
	[Token(Token = "0x60005A4")]
	public override IEnumerable<String> GetDynamicMemberNames(T instance) { }

	[Address(RVA = "0x1951060", Offset = "0x1950460", Length = "0x1E")]
	[Token(Token = "0x60005A5")]
	public override bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object result) { }

	[Address(RVA = "0x1951080", Offset = "0x1950480", Length = "0x1C")]
	[Token(Token = "0x60005A6")]
	public override bool TryConvert(T instance, ConvertBinder binder, out object result) { }

	[Address(RVA = "0x1951060", Offset = "0x1950460", Length = "0x1E")]
	[Token(Token = "0x60005A7")]
	public override bool TryCreateInstance(T instance, CreateInstanceBinder binder, Object[] args, out object result) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60005A8")]
	public override bool TryDeleteIndex(T instance, DeleteIndexBinder binder, Object[] indexes) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60005A9")]
	public override bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }

	[Address(RVA = "0x1951060", Offset = "0x1950460", Length = "0x1E")]
	[Token(Token = "0x60005AA")]
	public override bool TryGetIndex(T instance, GetIndexBinder binder, Object[] indexes, out object result) { }

	[Address(RVA = "0x1951080", Offset = "0x1950480", Length = "0x1C")]
	[Token(Token = "0x60005AB")]
	public override bool TryGetMember(T instance, GetMemberBinder binder, out object result) { }

	[Address(RVA = "0x1951060", Offset = "0x1950460", Length = "0x1E")]
	[Token(Token = "0x60005AC")]
	public override bool TryInvoke(T instance, InvokeBinder binder, Object[] args, out object result) { }

	[Address(RVA = "0x1951060", Offset = "0x1950460", Length = "0x1E")]
	[Token(Token = "0x60005AD")]
	public override bool TryInvokeMember(T instance, InvokeMemberBinder binder, Object[] args, out object result) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60005AE")]
	public override bool TrySetIndex(T instance, SetIndexBinder binder, Object[] indexes, object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60005AF")]
	public override bool TrySetMember(T instance, SetMemberBinder binder, object value) { }

	[Address(RVA = "0x1951080", Offset = "0x1950480", Length = "0x1C")]
	[Token(Token = "0x60005B0")]
	public override bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object result) { }

}

