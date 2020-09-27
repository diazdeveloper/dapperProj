EXEC sp_addextendedproperty 
    @name = N'MS_Description', @value = 'Genre ID|UID|UID',
    @level0type = N'Schema',   @level0name = 'dbo',
    @level1type = N'Table',    @level1name = 'Genre',
    @level2type = N'Column',   @level2name = 'GenreId';
GO

EXEC sp_addextendedproperty 
    @name = N'MS_Description', @value = 'Genre|Enter a Genre (ie Jazz)|Musical Genre',
    @level0type = N'Schema',   @level0name = 'dbo',
    @level1type = N'Table',    @level1name = 'Genre',
    @level2type = N'Column',   @level2name = 'Name';
GO