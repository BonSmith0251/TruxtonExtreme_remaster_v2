namespace UnityEngine.Rendering;

[Token(Token = "0x2000227")]
public sealed class VolumeProfile : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000229")]
	private sealed class <>c
	{
		[Token(Token = "0x40009A9")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40009AA")]
		public static Predicate<VolumeComponent> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x2C67E50", Offset = "0x2C67250", Length = "0x67")]
		[Token(Token = "0x6000F8A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F8B")]
		public <>c() { }

		[Address(RVA = "0x2C67D30", Offset = "0x2C67130", Length = "0x4C")]
		[Token(Token = "0x6000F8C")]
		internal bool <OnEnable>b__6_0(VolumeComponent x) { }

	}

	[Flags]
	[Token(Token = "0x2000228")]
	public enum DirtyState : int
	{
		None = 0,
		DirtyByComponentChange = 1,
		DirtyByProfileReset = 2,
		Other = 4,
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009A2")]
	public List<VolumeComponent> components; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009A3")]
	internal DirtyState dirtyState; //Field offset: 0x20

	[Obsolete("This field was only public for editor access. #from(6000.0)")]
	[Token(Token = "0x170001FC")]
	public bool isDirty
	{
		[Address(RVA = "0x2C6AC70", Offset = "0x2C6A070", Length = "0x8")]
		[Token(Token = "0x6000F76")]
		 get { } //Length: 8
		[Address(RVA = "0x2C6AC80", Offset = "0x2C6A080", Length = "0x19")]
		[Token(Token = "0x6000F77")]
		 set { } //Length: 25
	}

	[Address(RVA = "0x2C6ABF0", Offset = "0x2C69FF0", Length = "0x77")]
	[Token(Token = "0x6000F89")]
	public VolumeProfile() { }

	[Address(RVA = "0x2C6A220", Offset = "0x2C69620", Length = "0x139")]
	[Token(Token = "0x6000F7C")]
	public VolumeComponent Add(Type type, bool overrides = false) { }

	[Address(RVA = "0x9E61D0", Offset = "0x9E55D0", Length = "0xBA")]
	[Token(Token = "0x6000F7B")]
	public T Add(bool overrides = false) { }

	[Address(RVA = "0x2C6AC70", Offset = "0x2C6A070", Length = "0x8")]
	[Token(Token = "0x6000F76")]
	public bool get_isDirty() { }

	[Address(RVA = "0x2C6A360", Offset = "0x2C69760", Length = "0xC1")]
	[Token(Token = "0x6000F87")]
	internal int GetComponentListHashCode() { }

	[Address(RVA = "0x2C6A430", Offset = "0x2C69830", Length = "0xB2")]
	[Token(Token = "0x6000F86")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C6A660", Offset = "0x2C69A60", Length = "0x174")]
	[Token(Token = "0x6000F80")]
	public bool Has(Type type) { }

	[Address(RVA = "0x9E6290", Offset = "0x9E5690", Length = "0x5D")]
	[Token(Token = "0x6000F7F")]
	public bool Has() { }

	[Address(RVA = "0x2C6A4F0", Offset = "0x2C698F0", Length = "0x169")]
	[Token(Token = "0x6000F81")]
	public bool HasSubclassOf(Type type) { }

	[Address(RVA = "0x2C6A7E0", Offset = "0x2C69BE0", Length = "0xEF")]
	[Token(Token = "0x6000F79")]
	internal void OnDisable() { }

	[Address(RVA = "0x2C6A8D0", Offset = "0x2C69CD0", Length = "0x11B")]
	[Token(Token = "0x6000F78")]
	private void OnEnable() { }

	[Address(RVA = "0x9E62F0", Offset = "0x9E56F0", Length = "0x5D")]
	[Token(Token = "0x6000F7D")]
	public void Remove() { }

	[Address(RVA = "0x2C6A9F0", Offset = "0x2C69DF0", Length = "0x105")]
	[Token(Token = "0x6000F7E")]
	public void Remove(Type type) { }

	[Address(RVA = "0x2C6AB00", Offset = "0x2C69F00", Length = "0x5")]
	[Token(Token = "0x6000F7A")]
	public void Reset() { }

	[Address(RVA = "0x2C6AB10", Offset = "0x2C69F10", Length = "0xD4")]
	[Token(Token = "0x6000F88")]
	internal void Sanitize() { }

	[Address(RVA = "0x2C6AC80", Offset = "0x2C6A080", Length = "0x19")]
	[Token(Token = "0x6000F77")]
	public void set_isDirty(bool value) { }

	[Address(RVA = "0x9E6770", Offset = "0x9E5B70", Length = "0x7C")]
	[Token(Token = "0x6000F82")]
	public bool TryGet(out T component) { }

	[Address(RVA = "0x9E67F0", Offset = "0x9E5BF0", Length = "0x21A")]
	[Token(Token = "0x6000F83")]
	public bool TryGet(Type type, out T component) { }

	[Address(RVA = "0x9E6350", Offset = "0x9E5750", Length = "0x1F7")]
	[Token(Token = "0x6000F85")]
	public bool TryGetAllSubclassOf(Type type, List<T> result) { }

	[Address(RVA = "0x9E6550", Offset = "0x9E5950", Length = "0x21B")]
	[Token(Token = "0x6000F84")]
	public bool TryGetSubclassOf(Type type, out T component) { }

}

