namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[Token(Token = "0x2000287")]
public class HashSet : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x2000288")]
	public struct ElementCount
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049D")]
		internal int uniqueCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049E")]
		internal int unfoundCount; //Field offset: 0x0

	}

	[Token(Token = "0x200028A")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A2")]
		private HashSet<T> _set; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A3")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A4")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A5")]
		private T _current; //Field offset: 0x0

		[Token(Token = "0x1700028C")]
		public override T Current
		{
			[Address(RVA = "0x195BCB0", Offset = "0x195B0B0", Length = "0x15")]
			[Token(Token = "0x6000CEB")]
			 get { } //Length: 21
		}

		[Token(Token = "0x1700028D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1962450", Offset = "0x1961850", Length = "0xC9")]
			[Token(Token = "0x6000CEC")]
			private get { } //Length: 201
		}

		[Address(RVA = "0x1963290", Offset = "0x1962690", Length = "0x47")]
		[Token(Token = "0x6000CE8")]
		internal Enumerator(HashSet<T> set) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000CE9")]
		public override void Dispose() { }

		[Address(RVA = "0x195BCB0", Offset = "0x195B0B0", Length = "0x15")]
		[Token(Token = "0x6000CEB")]
		public override T get_Current() { }

		[Address(RVA = "0x195CFA0", Offset = "0x195C3A0", Length = "0x118")]
		[Token(Token = "0x6000CEA")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1962450", Offset = "0x1961850", Length = "0xC9")]
		[Token(Token = "0x6000CEC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x19606B0", Offset = "0x195FAB0", Length = "0x7F")]
		[Token(Token = "0x6000CED")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x2000289")]
	public struct Slot
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049F")]
		internal int hashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A0")]
		internal int next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A1")]
		internal T value; //Field offset: 0x0

	}

	[Token(Token = "0x400048E")]
	private const int Lower31BitMask = 2147483647; //Field offset: 0x0
	[Token(Token = "0x400048F")]
	private const int StackAllocThreshold = 100; //Field offset: 0x0
	[Token(Token = "0x4000490")]
	private const int ShrinkThreshold = 3; //Field offset: 0x0
	[Token(Token = "0x4000491")]
	private const string CapacityName = "Capacity"; //Field offset: 0x0
	[Token(Token = "0x4000492")]
	private const string ElementsName = "Elements"; //Field offset: 0x0
	[Token(Token = "0x4000493")]
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	[Token(Token = "0x4000494")]
	private const string VersionName = "Version"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000495")]
	private Int32[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000496")]
	private Slot<T>[] _slots; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000497")]
	private int _count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000498")]
	private int _lastIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000499")]
	private int _freeList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049A")]
	private IEqualityComparer<T> _comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049B")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049C")]
	private SerializationInfo _siInfo; //Field offset: 0x0

	[Token(Token = "0x1700028B")]
	public IEqualityComparer<T> Comparer
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000CDA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000289")]
	public override int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000CCC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700028A")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CCD")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x1C48E80", Offset = "0x1C48280", Length = "0x8F")]
	[Token(Token = "0x6000CBF")]
	public HashSet`1() { }

	[Address(RVA = "0x1C48F10", Offset = "0x1C48310", Length = "0x6A")]
	[Token(Token = "0x6000CC0")]
	public HashSet`1(IEqualityComparer<T> comparer) { }

	[Address(RVA = "0x1C48D60", Offset = "0x1C48160", Length = "0x111")]
	[Token(Token = "0x6000CC1")]
	public HashSet`1(int capacity) { }

	[Address(RVA = "0x1C494F0", Offset = "0x1C488F0", Length = "0x57")]
	[Token(Token = "0x6000CC2")]
	public HashSet`1(IEnumerable<T> collection) { }

	[Address(RVA = "0x1C490B0", Offset = "0x1C484B0", Length = "0x434")]
	[Token(Token = "0x6000CC3")]
	public HashSet`1(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }

	[Address(RVA = "0x1C48F80", Offset = "0x1C48380", Length = "0x31")]
	[Token(Token = "0x6000CC4")]
	protected HashSet`1(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1C48FC0", Offset = "0x1C483C0", Length = "0xEC")]
	[Token(Token = "0x6000CC6")]
	public HashSet`1(int capacity, IEqualityComparer<T> comparer) { }

	[Address(RVA = "0x1C45930", Offset = "0x1C44D30", Length = "0x38")]
	[Token(Token = "0x6000CD3")]
	public override bool Add(T item) { }

	[Address(RVA = "0x1C45470", Offset = "0x1C44870", Length = "0x3BA")]
	[Token(Token = "0x6000CDF")]
	private bool AddIfNotPresent(T value) { }

	[Address(RVA = "0x1C45830", Offset = "0x1C44C30", Length = "0xF9")]
	[Token(Token = "0x6000CE0")]
	private void AddValue(int index, int hashCode, T value) { }

	[Address(RVA = "0x1C45970", Offset = "0x1C44D70", Length = "0x7E")]
	[Token(Token = "0x6000CE6")]
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }

	[Address(RVA = "0x1C459F0", Offset = "0x1C44DF0", Length = "0x42E")]
	[Token(Token = "0x6000CE5")]
	private ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }

	[Address(RVA = "0x1C45E20", Offset = "0x1C45220", Length = "0x57")]
	[Token(Token = "0x6000CC8")]
	public override void Clear() { }

	[Address(RVA = "0x1C46060", Offset = "0x1C45460", Length = "0x25E")]
	[Token(Token = "0x6000CC9")]
	public override bool Contains(T item) { }

	[Address(RVA = "0x1C45E80", Offset = "0x1C45280", Length = "0x1D7")]
	[Token(Token = "0x6000CE1")]
	private bool ContainsAllElements(IEnumerable<T> other) { }

	[Address(RVA = "0x1C462C0", Offset = "0x1C456C0", Length = "0x306")]
	[Token(Token = "0x6000CC5")]
	private void CopyFrom(HashSet<T> source) { }

	[Address(RVA = "0x1C46600", Offset = "0x1C45A00", Length = "0x273")]
	[Token(Token = "0x6000CD8")]
	public void CopyTo(T[] array, int arrayIndex, int count) { }

	[Address(RVA = "0x1C46880", Offset = "0x1C45C80", Length = "0x29")]
	[Token(Token = "0x6000CCA")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0x1C465D0", Offset = "0x1C459D0", Length = "0x2C")]
	[Token(Token = "0x6000CD7")]
	public void CopyTo(T[] array) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000CDA")]
	public IEqualityComparer<T> get_Comparer() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000CCC")]
	public override int get_Count() { }

	[Address(RVA = "0x1C468B0", Offset = "0x1C45CB0", Length = "0x39")]
	[Token(Token = "0x6000CCE")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1C468F0", Offset = "0x1C45CF0", Length = "0x218")]
	[Token(Token = "0x6000CD1")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1C46B10", Offset = "0x1C45F10", Length = "0x1E8")]
	[Token(Token = "0x6000CDD")]
	private void IncreaseCapacity() { }

	[Address(RVA = "0x1C46D00", Offset = "0x1C46100", Length = "0xCC")]
	[Token(Token = "0x6000CDC")]
	private int Initialize(int capacity) { }

	[Address(RVA = "0x1C46DD0", Offset = "0x1C461D0", Length = "0xDA")]
	[Token(Token = "0x6000CE7")]
	private int InternalGetHashCode(T item) { }

	[Address(RVA = "0x1C46EB0", Offset = "0x1C462B0", Length = "0x251")]
	[Token(Token = "0x6000CE4")]
	private int InternalIndexOf(T item) { }

	[Address(RVA = "0x1C475F0", Offset = "0x1C469F0", Length = "0x2FA")]
	[Token(Token = "0x6000CD5")]
	public override void IntersectWith(IEnumerable<T> other) { }

	[Address(RVA = "0x1C47110", Offset = "0x1C46510", Length = "0x3C3")]
	[Token(Token = "0x6000CE3")]
	private void IntersectWithEnumerable(IEnumerable<T> other) { }

	[Address(RVA = "0x1C474E0", Offset = "0x1C468E0", Length = "0x10E")]
	[Token(Token = "0x6000CE2")]
	private void IntersectWithHashSetWithSameEC(HashSet<T> other) { }

	[Address(RVA = "0x1C478F0", Offset = "0x1C46CF0", Length = "0x75D")]
	[Token(Token = "0x6000CD2")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0x1C481B0", Offset = "0x1C475B0", Length = "0x331")]
	[Token(Token = "0x6000CCB")]
	public override bool Remove(T item) { }

	[Address(RVA = "0x1C48050", Offset = "0x1C47450", Length = "0x153")]
	[Token(Token = "0x6000CD9")]
	public int RemoveWhere(Predicate<T> match) { }

	[Address(RVA = "0x1C484F0", Offset = "0x1C478F0", Length = "0x137")]
	[Token(Token = "0x6000CDE")]
	private void SetCapacity(int newSize) { }

	[Address(RVA = "0x1C48630", Offset = "0x1C47A30", Length = "0x222")]
	[Token(Token = "0x6000CD6")]
	public override bool SetEquals(IEnumerable<T> other) { }

	[Address(RVA = "0x1C45930", Offset = "0x1C44D30", Length = "0x38")]
	[Token(Token = "0x6000CC7")]
	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CCD")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0x1C48860", Offset = "0x1C47C60", Length = "0x7E")]
	[Token(Token = "0x6000CCF")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0x1C48860", Offset = "0x1C47C60", Length = "0x7E")]
	[Token(Token = "0x6000CD0")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1C488E0", Offset = "0x1C47CE0", Length = "0x220")]
	[Token(Token = "0x6000CDB")]
	public void TrimExcess() { }

	[Address(RVA = "0x1C48B10", Offset = "0x1C47F10", Length = "0x24C")]
	[Token(Token = "0x6000CD4")]
	public override void UnionWith(IEnumerable<T> other) { }

}

