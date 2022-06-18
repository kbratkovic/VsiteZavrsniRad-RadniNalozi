﻿using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository;

public class SparePartRepository : ISparePartRepository
{
    private ZavrsniRadDbContext _dbContext;

    public SparePartRepository(ZavrsniRadDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<SparePartModel> SpareParts => _dbContext.SpareParts;



    public void CreateSparePart(SparePartModel sparePart)
    {
        throw new NotImplementedException();
    }

    public void DeleteSparePart(SparePartModel sparePart)
    {
        throw new NotImplementedException();
    }

    public void SaveSparePart(SparePartModel sparePart)
    {
        throw new NotImplementedException();
    }
}
