namespace System.IO.Enumeration;

[Token(Token = "0x2000688")]
public class FileSystemEnumerable : IEnumerable<TResult>, IEnumerable
{
	[Token(Token = "0x200068B")]
	private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001A6E")]
		private readonly FileSystemEnumerable<TResult> _enumerable; //Field offset: 0x0

		[Address(RVA = "0x17D5480", Offset = "0x17D4880", Length = "0x50")]
		[Token(Token = "0x6003140")]
		public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable) { }

		[Address(RVA = "0x17D51C0", Offset = "0x17D45C0", Length = "0x35")]
		[Token(Token = "0x6003143")]
		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

		[Address(RVA = "0x17D5290", Offset = "0x17D4690", Length = "0x35")]
		[Token(Token = "0x6003142")]
		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

		[Address(RVA = "0x17D53C0", Offset = "0x17D47C0", Length = "0x2E")]
		[Token(Token = "0x6003141")]
		protected virtual TResult TransformEntry(ref FileSystemEntry entry) { }

	}

	[Token(Token = "0x2000689")]
	internal sealed class FindPredicate : MulticastDelegate
	{

		[Address(RVA = "0x10DE5A0", Offset = "0x10DD9A0", Length = "0xB4")]
		[Token(Token = "0x600313C")]
		public FindPredicate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600313D")]
		public override bool Invoke(ref FileSystemEntry entry) { }

	}

	[Token(Token = "0x200068A")]
	internal sealed class FindTransform : MulticastDelegate
	{

		[Address(RVA = "0x10DE7E0", Offset = "0x10DDBE0", Length = "0xB4")]
		[Token(Token = "0x600313E")]
		public FindTransform(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600313F")]
		public override TResult Invoke(ref FileSystemEntry entry) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A68")]
	private DelegateEnumerator<TResult> _enumerator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A69")]
	private readonly FindTransform<TResult> _transform; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A6A")]
	private readonly EnumerationOptions _options; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A6B")]
	private readonly string _directory; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A6C")]
	private FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A6D")]
	private FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170007AD")]
	public FindPredicate<TResult> ShouldIncludePredicate
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003137")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6003138")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170007AE")]
	public FindPredicate<TResult> ShouldRecursePredicate
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003139")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1BBE5D0", Offset = "0x1BBD9D0", Length = "0x1A5")]
	[Token(Token = "0x6003136")]
	public FileSystemEnumerable`1(string directory, FindTransform<TResult> transform, EnumerationOptions options = null) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6003137")]
	public FindPredicate<TResult> get_ShouldIncludePredicate() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6003139")]
	public FindPredicate<TResult> get_ShouldRecursePredicate() { }

	[Address(RVA = "0x1BBE2F0", Offset = "0x1BBD6F0", Length = "0x7D")]
	[Token(Token = "0x600313A")]
	public override IEnumerator<TResult> GetEnumerator() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6003138")]
	public void set_ShouldIncludePredicate(FindPredicate<TResult> value) { }

	[Address(RVA = "0x1BBE370", Offset = "0x1BBD770", Length = "0x89")]
	[Token(Token = "0x600313B")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

