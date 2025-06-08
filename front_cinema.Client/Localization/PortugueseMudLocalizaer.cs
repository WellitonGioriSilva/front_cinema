using MudBlazor;
using Microsoft.Extensions.Localization;
namespace front_cinema.Client.Localization
{
    public class PortugueseMudLocalizer : MudLocalizer
    {
        public override LocalizedString this[string key]
        {
            get
            {
                var value = key switch
                {
                    "MudDataGridPager_RowsPerPage" => "Linhas por página",
                    "MudDataGridPager_Of" => "de",
                    "MudDataGridPager_Items" => "itens",
                    "MudDataGridPager_Page" => "Página",
                    "MudDataGridPager_FirstPage" => "Primeira página",
                    "MudDataGridPager_LastPage" => "Última página",
                    "MudDataGridPager_PreviousPage" => "Página anterior",
                    "MudDataGridPager_NextPage" => "Próxima página",
                    "MudDataGridPager_InfoFormat" => "{0}-{1} ({2})",
                    "MudStepper_Reset" => "Recomeçar",
                    "MudStepper_Previous" => "Voltar",
                    "MudStepper_Next" => "Avançar",
                    "MudStepper_Complete" => "Finalizar",

                    "PaginationRowsPerPage" => "Linhas por página",
                    "PaginationNext" => "Próximo",
                    "PaginationPrevious" => "Anterior",
                    "PaginationFirstPage" => "Primeira página",
                    "PaginationLastPage" => "Última página",
                    "TableSortLabel" => "Ordenar",
                    "Search" => "Pesquisar",
                    "ToggleGroup" => "Alternar grupo",
                    "Filter" => "Filtrar",
                    "Clear" => "Limpar",
                    "Close" => "Fechar",
                    "Cancel" => "Cancelar",
                    "Ok" => "OK",
                    "Save" => "Salvar",

                    _ => key
                };

                return new LocalizedString(key, value);
            }
        }
    }
}
