using System.Windows;

namespace Faterial.Controls
{
    /// <summary>
    /// Provides attached properties for adjusting the elevation depth along the z-axis of an element.
    /// </summary>
    public static class ElevationAssist
    {
        /// <summary>
        /// Identifies the <see cref="ElevationAssist" />.Level attached property.
        /// </summary>
        public static readonly DependencyProperty LevelProperty = DependencyProperty.RegisterAttached(
            "Level",
            typeof(ElevationLevel),
            typeof(ElevationAssist),
            new PropertyMetadata(ElevationLevel.Level0)
        );


        /// <summary>
        /// Gets the value of the <see cref="ElevationAssist" />.Level attached property
        /// from a given <see cref="DependencyObject" />.
        /// </summary>
        /// <param name="obj">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="ElevationAssist" />.Level attached property.
        /// </returns>
        public static ElevationLevel GetLevel(DependencyObject obj)
        {
            return (ElevationLevel)obj.GetValue(LevelProperty);
        }

        /// <summary>
        /// Sets the value of the <see cref="ElevationAssist" />.Level attached property
        /// to a given <see cref="DependencyObject" />.
        /// </summary>
        /// <param name="obj">
        /// The element on which to set the <see cref="ElevationAssist" />.Level attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetLevel(DependencyObject obj, ElevationLevel value)
        {
            obj.SetValue(LevelProperty, value);
        }
    }
}
