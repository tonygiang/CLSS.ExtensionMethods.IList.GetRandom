// A part of the C# Language Syntactic Sugar suite.

using System;
using System.Collections.Generic;

namespace CLSS
{
  public static partial class IListGetRandom
  {
    /// <summary>
    /// Returns a random element of the <see cref="IList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements of
    /// <paramref name="source"/>.</typeparam>
    /// <param name="source">The <see cref="IList{T}"/> to select a random
    /// element from.</param>
    /// <param name="rng">Optional custom-seeded random number generator to use
    /// for the sample rolls.</param>
    /// <returns>A random element.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> is
    /// null.</exception>
    public static T GetRandom<T>(this IList<T> source, Random rng = null)
    {
      if (source == null) throw new ArgumentNullException("source");
      if (rng == null) rng = DefaultRandom.Instance;
      return source[rng.Next(0, source.Count)];
    }
  }
}