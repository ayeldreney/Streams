import { Component } from '@angular/core';

@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent {


  searchResult: Document[] = [];


  constructor(private documentService: DocumentService) {

  }



  ngOnInit(): void {

  }

  search() {
    this.documentService.searchFlight({}).subscribe(responce => this.searchResult = responce, this.handleError, () => {
      console.log("search completed")
    });



  }




  private handleError = (err: any) => {
    console.log("Response Error. Status: ", err.status)
    console.log("Response Error. Status Text: ", err.statusText)
    console.log(err)
  }




}
