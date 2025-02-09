﻿namespace ProjectService.Entities.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Context
        private readonly ProjectContext _context;
        #endregion

        #region Repos
        public IGenericRepo<Project> Projects { get; private set; }
        #endregion

        #region Constructors
        public UnitOfWork(ProjectContext context)
        {
            _context = context;
            Projects = new GenericRepo<Project>(_context);
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion

        #region Save
        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
        #endregion
    }
}
