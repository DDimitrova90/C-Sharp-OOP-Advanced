namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string result = string.Empty;

            while (command != "HARVEST")
            {
                switch (command)
                {
                    case "private":
                        result = GetPrivateFields();
                        OutputWriter(result);
                        break;
                    case "protected":
                        result = GetProtectedFields();
                        OutputWriter(result);
                        break;
                    case "public":
                        result = GetPublicFields();
                        OutputWriter(result);
                        break;
                    case "all":
                        result = GetAllFields();
                        OutputWriter(result);
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static string GetAllFields()
        {
            StringBuilder sb = new StringBuilder();

            Type classType = typeof(HarvestingFields);
            FieldInfo[] fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (FieldInfo fieldInfo in fieldsInfo)
            {
                string accessModifier = fieldInfo.Attributes.ToString() == "Family" ? "protected" : fieldInfo.Attributes.ToString().ToLower();
                sb.AppendLine($"{accessModifier} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }

            return sb.ToString().Trim();
        }

        private static string GetPublicFields()
        {
            StringBuilder sb = new StringBuilder();

            Type classType = typeof(HarvestingFields);
            FieldInfo[] fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (FieldInfo fieldInfo in fieldsInfo)
            {
                sb.AppendLine($"public {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }

            return sb.ToString().Trim();
        }

        private static string GetProtectedFields()
        {
            StringBuilder sb = new StringBuilder();

            Type classType = typeof(HarvestingFields);
            FieldInfo[] fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo fieldInfo in fieldsInfo.Where(f => f.IsFamily))
            {
                sb.AppendLine($"protected {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }

            return sb.ToString().Trim();
        }

        private static string GetPrivateFields()
        {
            StringBuilder sb = new StringBuilder();

            Type classType = typeof(HarvestingFields);
            FieldInfo[] fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo fieldInfo in fieldsInfo.Where(f => f.IsPrivate))
            {
                sb.AppendLine($"private {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }

            return sb.ToString().Trim();
        }

        private static void OutputWriter(string result)
        {
            Console.WriteLine(result);
        }
    }
}
