namespace EntidadFinanciera.Interfaces
{
    public interface ICalculoSeguro
    {

        #region Metodos Abstractos

        decimal Prima(decimal cantidad, int edad);
        decimal Cancelacion(decimal cantidad);

        #endregion

        
    }
}