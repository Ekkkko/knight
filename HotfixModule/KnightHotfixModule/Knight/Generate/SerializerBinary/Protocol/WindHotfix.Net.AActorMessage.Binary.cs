using System.IO;
using Core;
using WindHotfix.Core;


/// <summary>
/// 文件自动生成无需又该！如果出现编译错误，删除文件后会自动生成
/// </summary>
namespace WindHotfix.Net
{
public partial class AActorMessage
{
	public override void Serialize(BinaryWriter rWriter)
	{
		base.Serialize(rWriter);
	}
	public override void Deserialize(BinaryReader rReader)
	{
		base.Deserialize(rReader);
	}
}
}