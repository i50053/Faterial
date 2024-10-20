using System.Windows;

namespace Faterial.Controls
{
    /// <summary>
    /// Provides attached properties for customizing the shape of an element.
    /// </summary>
    public static class ShapeAssist
    {
        /// <summary>
        /// Identifies the <see cref="ShapeAssist" />.CornerRadius attached property.
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(ShapeAssist),
            new PropertyMetadata(new CornerRadius(0))
        );


        /// <summary>
        /// Gets the value of the <see cref="ShapeAssist" />.CornerRadius attached property
        /// from a given <see cref="DependencyObject" />.
        /// </summary>
        /// <param name="obj">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="ShapeAssist" />.CornerRadius attached property.
        /// </returns>
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        /// <summary>
        /// Sets the value of the <see cref="ShapeAssist" />.CornerRadius attached property
        /// to a given <see cref="DependencyObject" />.
        /// </summary>
        /// <param name="obj">
        /// The element on which to set the <see cref="ShapeAssist" />.CornerRadius attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }
    }
}
