namespace System.ComponentModel;

[Token(Token = "0x200017A")]
public interface IBindingList : IList, ICollection, IEnumerable
{

	[Token(Token = "0x170001BD")]
	public bool AllowEdit
	{
		[Token(Token = "0x6000933")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001BC")]
	public bool AllowNew
	{
		[Token(Token = "0x6000931")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001BE")]
	public bool AllowRemove
	{
		[Token(Token = "0x6000934")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001C2")]
	public bool IsSorted
	{
		[Token(Token = "0x6000938")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001C4")]
	public ListSortDirection SortDirection
	{
		[Token(Token = "0x600093A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001C3")]
	public PropertyDescriptor SortProperty
	{
		[Token(Token = "0x6000939")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001BF")]
	public bool SupportsChangeNotification
	{
		[Token(Token = "0x6000935")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001C0")]
	public bool SupportsSearching
	{
		[Token(Token = "0x6000936")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001C1")]
	public bool SupportsSorting
	{
		[Token(Token = "0x6000937")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600093B")]
	public void AddIndex(PropertyDescriptor property) { }

	[Token(Token = "0x6000932")]
	public object AddNew() { }

	[Token(Token = "0x600093C")]
	public void ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	[Token(Token = "0x600093D")]
	public int Find(PropertyDescriptor property, object key) { }

	[Token(Token = "0x6000933")]
	public bool get_AllowEdit() { }

	[Token(Token = "0x6000931")]
	public bool get_AllowNew() { }

	[Token(Token = "0x6000934")]
	public bool get_AllowRemove() { }

	[Token(Token = "0x6000938")]
	public bool get_IsSorted() { }

	[Token(Token = "0x600093A")]
	public ListSortDirection get_SortDirection() { }

	[Token(Token = "0x6000939")]
	public PropertyDescriptor get_SortProperty() { }

	[Token(Token = "0x6000935")]
	public bool get_SupportsChangeNotification() { }

	[Token(Token = "0x6000936")]
	public bool get_SupportsSearching() { }

	[Token(Token = "0x6000937")]
	public bool get_SupportsSorting() { }

	[Token(Token = "0x600093E")]
	public void RemoveIndex(PropertyDescriptor property) { }

	[Token(Token = "0x600093F")]
	public void RemoveSort() { }

}

