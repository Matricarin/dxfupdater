using ACadSharp;
using ACadSharp.Entities;
using ACadSharp.IO;

namespace AcadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"Samples/2408.dxf";

           var doc = DxfReader.Read(path, new DxfReaderConfiguration()
            {
                ClearCache = true,
                CreateDefaults = true,
                Failsafe = true,
                KeepUnknownEntities = true,
                KeepUnknownNonGraphicalObjects = true
            });


            var texts = doc.Entities.Where(entity => entity.ObjectType == ObjectType.TEXT).ToArray();

            foreach (var entity in texts)
            {
                var text = entity as TextEntity;
                
                Console.WriteLine(text.Value);
            }

            Console.ReadLine();
        }
    }
}
