﻿Imports Vazor

Namespace Pages.Shared
    Partial Public Class PaginationView
        Inherits VazorSharedView

        Public Sub New()
            MyBase.New("_pagination", "Pages\Shared", "Pagination")
        End Sub

        Public Overrides Function GetVbXml() As XElement
            Return _
 _
        <zml xmlns:z="zml">
            <z:model>PaginationInfoViewModel</z:model>

            <div class="esh-pager">
                <div class="container-fluid">
                    <article class="esh-pager-wrapper row">
                        <nav>
                            <div class="col-md-2 col-xs-12">
                                <a class="esh-pager-item-left esh-pager-item--navigable esh-pager-item @Model.Previous"
                                    id="Previous"
                                    asp-route-pageid="@(Model.ActualPage - 1)"
                                    aria-label="Previous"> 
						Previous
				            	</a>
                            </div>

                            <div class="col-md-8 col-xs-12">
                                <span class="esh-pager-item">
						Showing @Model.ItemsPerPage of @Model.TotalItems products - Page @(Model.ActualPage + 1) - @Model.TotalPages
					</span>
                            </div>

                            <div class="col-md-2 col-xs-12">
                                <a class="esh-pager-item-right esh-pager-item--navigable esh-pager-item @Model.Next"
                                    id="Next"
                                    asp-route-pageid="@(Model.ActualPage + 1)"
                                    aria-label="Next">
						Next
					</a>
                            </div>
                        </nav>
                    </article>
                </div>
            </div>
        </zml>

        End Function


    End Class
End Namespace