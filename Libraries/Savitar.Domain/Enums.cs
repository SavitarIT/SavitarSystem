using System.ComponentModel;

namespace Savitar.Domain
{
    public enum Frequencies { Rarely, Sometimes, Frequently, Daily }
    public enum Proficiencies { Basic = 0, Novice = 1, Intermediate = 2, Advanced = 3, Expert = 4 }

    public enum UploadType : byte
    {
        [Description(@"Images\Products")]
        Product,

        [Description(@"Images\ProfilePictures")]
        ProfilePicture,

        [Description(@"Documents")]
        Document
    }
}
