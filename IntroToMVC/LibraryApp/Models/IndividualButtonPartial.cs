using System.Text;

namespace LibraryApp.Models
{
	public class IndividualButtonPartial
	{
		public string ButtonType { get; set; }
		public string Action { get; set; }
		public string Glyph { get; set; }
		public string Text { get; set; }
		public int? GenreId { get; set; }
		public int? BookId { get; set; }
		public int? MemberId { get; set; }
		public int? MemberShipId { get; set; }
		public string ActionParameter
		{
			get
			{
				var param = new StringBuilder("@/");
				if (BookId != null && BookId > 0)
				{
					param.Append(String.Format("{0}", BookId));
				}
				if (GenreId != null && GenreId > 0)
				{
					param.Append(String.Format("{0}", GenreId));
				}
				if (MemberId != null && MemberId > 0)
				{
					param.Append(String.Format("{0}", MemberId));
				}
				if (MemberShipId != null && MemberShipId > 0)
				{
					param.Append(String.Format("{0}", MemberShipId));
				}
				return param.ToString();
			}
		}
	}


}

