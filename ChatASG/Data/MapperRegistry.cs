
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//public interface IMapper<TSource, TDestination>
//{
//    TDestination Map(TSource source);
//}

//public class GenericMapper<TSource, TDestination> : IMapper<TSource, TDestination>
//    where TDestination : new()
//{
//    public TDestination Map(TSource source)
//    {
//        if (source == null)
//            throw new ArgumentNullException(nameof(source));

//        var destination = new TDestination();

//        var sourceProperties = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
//        var destProperties = typeof(TDestination).GetProperties(BindingFlags.Public | BindingFlags.Instance);

//        foreach (var destProp in destProperties)
//        {
//            if (!destProp.CanWrite) continue;

//            var sourceProp = sourceProperties.FirstOrDefault(p => p.Name == destProp.Name);
//            if (sourceProp == null || !sourceProp.CanRead) continue;

//            var sourceValue = sourceProp.GetValue(source);
//            var destPropType = destProp.PropertyType;

//            // Œ«’Ì… null
//            if (sourceValue == null)
//            {
//                if (IsGenericList(destPropType))
//                {
//                    var emptyList = Activator.CreateInstance(destPropType);
//                    destProp.SetValue(destination, emptyList);
//                }
//                else
//                {
//                    destProp.SetValue(destination, null);
//                }
//                continue;
//            }

//            var sourcePropType = sourceProp.PropertyType;

//            // „⁄«·Ã… «·ﬁÊ«∆„
//            if (IsGenericList(destPropType) && IsGenericList(sourcePropType))
//            {
//                var sourceItemType = sourcePropType.GetGenericArguments()[0];
//                var destItemType = destPropType.GetGenericArguments()[0];

//                var listInstance = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(destItemType))!;

//                foreach (var item in (IEnumerable)sourceValue)
//                {
//                    if (destItemType.IsAssignableFrom(sourceItemType))
//                    {
//                        listInstance.Add(item);
//                    }
//                    else
//                    {
//                        var mappedItem = MapDynamic(item, sourceItemType, destItemType);
//                        listInstance.Add(mappedItem);
//                    }
//                }

//                destProp.SetValue(destination, listInstance);
//            }
//            // ‰›” «·‰Ê⁄° «‰”Œ „»«‘—…
//            else if (destPropType.IsAssignableFrom(sourcePropType))
//            {
//                destProp.SetValue(destination, sourceValue);
//            }
//            // Œ’«∆’ „—ﬂ»…  Õ «Ã  ÕÊÌ·
//            else
//            {
//                var mappedInner = MapDynamic(sourceValue, sourcePropType, destPropType);
//                destProp.SetValue(destination, mappedInner);
//            }
//        }

//        return destination;
//    }

//    private bool IsGenericList(Type type)
//    {
//        return type.IsGenericType &&
//               (type.GetGenericTypeDefinition() == typeof(List<>) ||
//                typeof(IEnumerable).IsAssignableFrom(type)); // œ⁄„ IEnumerable ≈÷«›Ì
//    }

//    private object MapDynamic(object source, Type sourceType, Type destType)
//    {
//        var mapperType = typeof(GenericMapper<,>).MakeGenericType(sourceType, destType);
//        var mapper = Activator.CreateInstance(mapperType);
//        var mapMethod = mapperType.GetMethod("Map")!;
//        return mapMethod.Invoke(mapper, new[] { source })!;
//    }
//}

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//public interface IMapper<TSource, TDestination>
//{
//    TDestination Map(TSource source);
//}

//public class GenericMapper<TSource, TDestination> : IMapper<TSource, TDestination>
//    where TDestination : new()
//{
//    public TDestination Map(TSource source)
//    {
//        if (source == null)
//            throw new ArgumentNullException(nameof(source));

//        var destination = new TDestination();

//        var sourceProperties = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
//        var destProperties = typeof(TDestination).GetProperties(BindingFlags.Public | BindingFlags.Instance);

//        foreach (var destProp in destProperties)
//        {
//            if (!destProp.CanWrite) continue;

//            var sourceProp = sourceProperties.FirstOrDefault(p => p.Name == destProp.Name);
//            if (sourceProp == null || !sourceProp.CanRead) continue;

//            var sourceValue = sourceProp.GetValue(source);
//            var destPropType = destProp.PropertyType;

//            // Œ«’Ì… null
//            if (sourceValue == null)
//            {
//                if (IsGenericList(destPropType))
//                {
//                    var emptyList = Activator.CreateInstance(destPropType);
//                    destProp.SetValue(destination, emptyList);
//                }
//                else
//                {
//                    destProp.SetValue(destination, null);
//                }
//                continue;
//            }

//            var sourcePropType = sourceProp.PropertyType;

//            // „⁄«·Ã… «·ﬁÊ«∆„
//            if (IsGenericList(destPropType) && IsGenericList(sourcePropType))
//            {
//                var sourceItemType = sourcePropType.GetGenericArguments()[0];
//                var destItemType = destPropType.GetGenericArguments()[0];

//                var listInstance = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(destItemType))!;

//                foreach (var item in (IEnumerable)sourceValue)
//                {
//                    if (destItemType.IsAssignableFrom(sourceItemType))
//                    {
//                        listInstance.Add(item);
//                    }
//                    else
//                    {
//                        var mappedItem = MapDynamic(item, sourceItemType, destItemType);
//                        listInstance.Add(mappedItem);
//                    }
//                }

//                destProp.SetValue(destination, listInstance);
//            }
//            // ‰›” «·‰Ê⁄° «‰”Œ „»«‘—…
//            else if (destPropType.IsAssignableFrom(sourcePropType))
//            {
//                destProp.SetValue(destination, sourceValue);
//            }
//            // Œ’«∆’ „—ﬂ»…  Õ «Ã  ÕÊÌ·
//            else
//            {
//                var mappedInner = MapDynamic(sourceValue, sourcePropType, destPropType);
//                destProp.SetValue(destination, mappedInner);
//            }
//        }

//        return destination;
//    }

//    private bool IsGenericList(Type type)
//    {
//        return type.IsGenericType &&
//               (type.GetGenericTypeDefinition() == typeof(List<>) ||
//                typeof(IEnumerable).IsAssignableFrom(type)); // œ⁄„ IEnumerable ≈÷«›Ì
//    }

//    private object MapDynamic(object source, Type sourceType, Type destType)
//    {
//        var mapperType = typeof(GenericMapper<,>).MakeGenericType(sourceType, destType);
//        var mapper = Activator.CreateInstance(mapperType);
//        var mapMethod = mapperType.GetMethod("Map")!;
//        return mapMethod.Invoke(mapper, new[] { source })!;
//    }
//}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public interface IMapper<TSource, TDestination>
{
    TDestination Map(TSource source);
}

public class GenericMapper<TSource, TDestination> : IMapper<TSource, TDestination>
    where TDestination : new()
{
    public TDestination Map(TSource source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        var destination = new TDestination();

        var sourceProperties = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var destProperties = typeof(TDestination).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var destProp in destProperties)
        {
            if (!destProp.CanWrite) continue;

            // œ⁄„  ÿ«»ﬁ «·√”„«¡ »œÊ‰ Õ”«”Ì… ·Õ«·… «·√Õ—›
            var sourceProp = sourceProperties.FirstOrDefault(p =>
                string.Equals(p.Name, destProp.Name, StringComparison.OrdinalIgnoreCase));
            if (sourceProp == null || !sourceProp.CanRead) continue;

            var sourceValue = sourceProp.GetValue(source);
            var destPropType = destProp.PropertyType;

            if (sourceValue == null)
            {
                if (IsGenericList(destPropType))
                {
                    var emptyList = Activator.CreateInstance(destPropType);
                    destProp.SetValue(destination, emptyList);
                }
                else
                {
                    destProp.SetValue(destination, null);
                }
                continue;
            }

            var sourcePropType = sourceProp.PropertyType;

            if (IsGenericList(destPropType) && IsGenericList(sourcePropType))
            {
                var sourceItemType = sourcePropType.GetGenericArguments()[0];
                var destItemType = destPropType.GetGenericArguments()[0];

                var listInstance = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(destItemType))!;

                foreach (var item in (IEnumerable)sourceValue)
                {
                    if (destItemType.IsAssignableFrom(sourceItemType))
                    {
                        listInstance.Add(item);
                    }
                    else
                    {
                        var mappedItem = MapDynamic(item, sourceItemType, destItemType);
                        listInstance.Add(mappedItem);
                    }
                }

                destProp.SetValue(destination, listInstance);
            }
            else if (destPropType.IsAssignableFrom(sourcePropType))
            {
                destProp.SetValue(destination, sourceValue);
            }
            else
            {
                var mappedInner = MapDynamic(sourceValue, sourcePropType, destPropType);
                destProp.SetValue(destination, mappedInner);
            }
        }

        return destination;
    }

    private bool IsGenericList(Type type)
    {
        return type.IsGenericType &&
               (type.GetGenericTypeDefinition() == typeof(List<>) ||
                typeof(IEnumerable).IsAssignableFrom(type));
    }

    private object MapDynamic(object source, Type sourceType, Type destType)
    {
        var mapperType = typeof(GenericMapper<,>).MakeGenericType(sourceType, destType);
        var mapper = Activator.CreateInstance(mapperType);
        var mapMethod = mapperType.GetMethod("Map")!;
        return mapMethod.Invoke(mapper, new[] { source })!;
    }
}
