using System;
using System.Reflection;

public static class ObjectExtensions
{
    
    public static void ForEachField(this Object target, Action<FieldInfo> forEachCallback)
    {
        var type = target.GetType();
        
        FieldInfo[] elementFields = type.GetFields();

        for(int i = 0; i < elementFields.Length; i++)
        {
            forEachCallback?.Invoke(elementFields[i]);
        }
    }
    
    public static void ForEachProperty(this Object target, Action<PropertyInfo> forEachCallback)
    {
        var type = target.GetType();
        
        PropertyInfo[] elementProperties = type.GetProperties();

        for(int i = 0; i < elementProperties.Length; i++)
        {
            forEachCallback?.Invoke(elementProperties[i]);
        }
    }
    
}
