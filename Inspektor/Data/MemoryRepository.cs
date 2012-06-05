using System;
using System.Collections.Generic;
using System.Linq;
using Inspektor.Models;

namespace Inspektor.Data
{
    public class MemoryRepository:IRepository
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> Find<T>()
        {
            if (typeof(T) == typeof(FeatureUsage))
            {
                var usage = new[]
                                {
                                    new FeatureUsage
                                        {
                                            Feature = new Feature{ApplicationName = "Magnet",FeatureName = "Home"},
                                            UsedBy = @"PARAPORT\JoshR",
                                            UsedDate = DateTime.Now.AddDays(-4)
                                        },
                                         new FeatureUsage
                                        {
                                            Feature = new Feature{ApplicationName = "Verona",FeatureName = "Home"},
                                            UsedBy = @"PARAPORT\JoshR",
                                            UsedDate = DateTime.Now.AddDays(-4)
                                        },
                                         new FeatureUsage
                                        {
                                            Feature = new Feature{ApplicationName = "Magnet",FeatureName = "Home"},
                                            UsedBy = @"PARAPORT\JoshR",
                                            UsedDate = DateTime.Now.AddDays(-2)
                                        },
                                         new FeatureUsage
                                        {
                                            Feature = new Feature{ApplicationName = "Magnet",FeatureName = "FX"},
                                            UsedBy = @"PARAPORT\Other",
                                            UsedDate = DateTime.Now.AddDays(-2)
                                        }

                                };

                return new EnumerableQuery<FeatureUsage>(usage) as EnumerableQuery<T>;
            }

            return null;
        }

        public T Get<T, I>( I key )
        {
            throw new System.NotImplementedException();
        }

        public void Save<T>( T toSave )
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>( T toDelete )
        {
            throw new System.NotImplementedException();
        }

        public void DeleteById<I>( I key )
        {
            throw new System.NotImplementedException();
        }
    }
}