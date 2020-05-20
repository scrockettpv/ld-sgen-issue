using System;
using System.IO;
using System.Web.UI;
using ClassLibrary1;

namespace WebApplication3
{
  public partial class _Default : Page
  {
    public string Foo;

    protected void Page_Load(object sender, EventArgs e)
    {
      Foo = WriteObject(new Class1 {ValueOne = "foo"});
    }

    
    public static string WriteObject(Class1 testSerializations)
    {
      var writer = new System.Xml.Serialization.XmlSerializer(typeof(Class1));

      var stringWriter = new StringWriter();

      writer.Serialize(stringWriter, testSerializations);

      return stringWriter.ToString();
    }
  }
}