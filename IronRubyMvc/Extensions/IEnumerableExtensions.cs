#region Usings

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using IronRuby.Builtins;

#endregion

namespace System.Web.Mvc.IronRuby.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var t in collection)
            {
                action(t);
            }
        }

        public static void ForEach(this IEnumerable collection, Action<object> action)
        {
            foreach (var o in collection)
            {
                action(o);
            }
        }
		
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> collection, Predicate<TSource> predicate)
        {
            foreach (var source in collection)
            {
                if (predicate(source)) yield return source;
            }
        }
		
		public static bool Contains<T>(this IEnumerable<T> collection, T value)
        {
            foreach (var t in collection)
            {
                if ((t.IsNull() && value.IsNull()) || (t.IsNotNull() && t.Equals(value))) return true;
            }
            return false;
        }
		
		internal static int Count(this IEnumerable collection)
        {
            var count = 0;
            foreach (var o in collection)
            {
                count++;
            }
            return count;
        }
		
		internal static IEnumerable<TTarget> Cast<TTarget>(this IEnumerable collection) where TTarget : class
        {
            var result = new List<TTarget>();
            collection.ForEach(item =>
                                   {
                                       var casted = (typeof (TTarget) == typeof (string)) ? item.ToString() as TTarget : item as TTarget;
                                       if (casted.IsNotNull()) result.Add(casted);
                                   });
            return result;
        }
		
		public static bool All<TSource>(this IEnumerable<TSource> collection, Predicate<TSource> predicate)
        {
            foreach (var source in collection)
            {
                if (!predicate(source)) return false;
            }
            return true;
        }
 
        public static bool Any<TSource>(this IEnumerable<TSource> collection, Predicate<TSource> predicate)
        {
            foreach (var source in collection)
            {
                if (predicate(source)) return true;
            }
            return false;
        }
		
		internal static TSource[] ToArray<TSource>(this IEnumerable<TSource> collection)
        {
            var result = new TSource[collection.Count()];
            var idx = 0;
 
            collection.ForEach(item => result[idx++] = item);
 
            return result;
        }
		
		internal static int Count<TSource>(this IEnumerable<TSource> collection, Predicate<TSource> predicate)
        {
            var count = 0;
            foreach (var o in collection)
            {
                if (predicate(o)) count++;
            }
            return count;
        }

        [SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "o")]
        public static bool IsEmpty<T>(this IEnumerable<T> collection)
        {
            // not guarding for null foreach does that for me
            foreach (var o in collection)
            {
                return false;
            }
            return true;
        }

        [SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "o")]
        public static bool IsEmpty(this IEnumerable collection)
        {
            // not guarding for null, foreach does that for me
            foreach (var o in collection)
            {
                return false;
            }
            return true;
        }

        internal static bool DoesNotContain<TSource>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            foreach (var o in collection)
            {
                if (predicate(o)) return false;
            }
            return true;
        }

        internal static IEnumerable<TTarget> Map<TSource, TTarget>(this IEnumerable<TSource> collection, Func<TSource, TTarget> iterator)
        {
            foreach (var source in collection)
            {
                yield return iterator(source);
            }
        }

        internal static IEnumerable Map(this IEnumerable collection, Func<object, object> iterator)
        {
            foreach (var source in collection)
            {
                yield return iterator(source);
            }
        }

        internal static IEnumerable<SelectListItem> ToSelectListItemList(this IEnumerable collection)
        {
            var result = new List<SelectListItem>();

            collection.ForEach(item =>
                                   {
                                       var hash = (Hash) item;
                                       var li = new SelectListItem();
                                       hash.ForEach((key, value) =>
                                                        {
                                                            if (key.ToString() == "text")
                                                                li.Text = value.ToString();
                                                            if (key.ToString() == "value")
                                                                li.Value = value.ToString();
                                                            if (key.ToString() == "selected")
                                                                li.Selected = (bool) value;
                                                        });
                                       result.Add(li);
                                   });
            return result;
        }

        internal static IEnumerable<TTarget> CastTo<TTarget>(this IEnumerable collection) where TTarget : class
        {
            var result = new List<TTarget>();
            collection.ForEach(item =>
            {
                var casted = (typeof(TTarget) == typeof(string)) ? item.ToString() as TTarget : item as TTarget;
                if (casted.IsNotNull()) result.Add(casted);
            });
            return result;
        }
    }
}