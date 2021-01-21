
Create Procedure BankPortifolioBusiness
@IdClient int,
@Value decimal(12,2),
@IdPortifolio int,
@TypeBusiness varchar(20)
as

declare @SectorClient varchar(20),
        @IdCategory int

set @SectorClient = (SELECT sectorclient FROM Client C WHERE IDCLIENT = @IdClient)
set @IdPortifolio = (SELECT IdPortifolio FROM Portifolio WHERE IdPortifolio = @IdPortifolio)

if @Value < 1000000.00 and @SectorClient = 'Private'
begin
set @IdCategory = 1
end
else if @Value > 1000000.00 and @SectorClient = 'Private'
begin
set @IdCategory = 3
end 

if @Value > 1000000.00 and @SectorClient = 'Public'
begin
set @IdCategory = 2
end
else if @Value < 1000000.00 and @SectorClient = 'Public'
begin
set @IdCategory = 1
end 

BEGIN TRY
INSERT INTO Business (IdPortifolio,IdCategory,IdClient,TypeBusiness,DateRegister,ValueBusiness) VALUES(@IdPortifolio,@IdCategory,@IdClient,@TypeBusiness,GETDATE(),@Value)
END TRY

          BEGIN CATCH
              SELECT
                    ERROR_NUMBER() AS ErrorNumber,
                    ERROR_STATE() AS ErrorState,
                    ERROR_SEVERITY() AS ErrorSeverity,
                    ERROR_PROCEDURE() AS ErrorProcedure,
                    ERROR_LINE() AS ErrorLine,
                    ERROR_MESSAGE() AS ErrorMessage;
          END CATCH
