#region Notes on Models
/* 
  * Since we are using Entity Core, since we're setting
    the first property to "Id", Entity will know that this is
    our primary Key.
*/
#endregion

namespace CmdApi.Models
{
  public class Command
  {
    public int Id { get; set; }
    public string HowTo { get; set; }
    public string Platform { get; set; }
    public string Commandline { get; set; }
  }
}