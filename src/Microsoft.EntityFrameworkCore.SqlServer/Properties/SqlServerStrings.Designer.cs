// <auto-generated />
namespace Microsoft.EntityFrameworkCore.Internal
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using JetBrains.Annotations;

    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static partial class SqlServerStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.SqlServer.Properties.SqlServerStrings", typeof(SqlServerStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// Identity value generation cannot be used for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Identity value generation can only be used with signed integer properties.
        /// </summary>
        public static string IdentityBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("IdentityBadType", "property", "entityType", "propertyType"), property, entityType, propertyType);
        }

        /// <summary>
        /// Data type '{dataType}' is not supported in this form. Either specify the length explicitly in the type name, for example as '{dataType}(16)', or remove the data type and use APIs such as HasMaxLength to allow EF choose the data type.
        /// </summary>
        public static string UnqualifiedDataType([CanBeNull] object dataType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnqualifiedDataType", "dataType"), dataType);
        }

        /// <summary>
        /// SQL Server sequences cannot be used to generate values for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Sequences can only be used with integer properties.
        /// </summary>
        public static string SequenceBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SequenceBadType", "property", "entityType", "propertyType"), property, entityType, propertyType);
        }

        /// <summary>
        /// SQL Server requires the table name to be specified for rename index operations. Specify table name in the call to MigrationBuilder.RenameIndex.
        /// </summary>
        public static string IndexTableRequired
        {
            get { return GetString("IndexTableRequired"); }
        }

        /// <summary>
        /// To set memory-optimized on a table on or off the table needs to be dropped and recreated.
        /// </summary>
        public static string AlterMemoryOptimizedTable
        {
            get { return GetString("AlterMemoryOptimizedTable"); }
        }

        /// <summary>
        /// To change the IDENTITY property of a column, the column needs to be dropped and recreated.
        /// </summary>
        public static string AlterIdentityColumn
        {
            get { return GetString("AlterIdentityColumn"); }
        }

        /// <summary>
        /// An exception has been raised that is likely due to a transient failure. If you are connecting to a SQL Azure database consider using SqlAzureExecutionStrategy.
        /// </summary>
        public static string TransientExceptionDetected
        {
            get { return GetString("TransientExceptionDetected"); }
        }

        /// <summary>
        /// No type was specified for the decimal column '{property}' on entity type '{entityType}'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accomadate all the values using 'ForSqlServerHasColumnType()'.
        /// </summary>
        public static string DefaultDecimalTypeColumn([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DefaultDecimalTypeColumn", "property", "entityType"), property, entityType);
        }

        /// <summary>
        /// The property '{property}' on entity type '{entityType}' is configured to use 'Identity' or 'SequenceHiLo' value generator, which are only intended for keys. If this was intentional configure an alternate key on the property, otherwise call `ValueGeneratedNever` or configure store generation for this property.
        /// </summary>
        public static string NonKeyValueGeneration([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NonKeyValueGeneration", "property", "entityType"), property, entityType);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
