import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { SurveyDataService } from "@services/survey-data.service";

@Component({
  selector: "app-result",
  templateUrl: "./result.component.html",
  styleUrls: ["./result.component.scss"]
})
export class ResultComponent implements OnInit {
  clientId: string;
  data: any;

  constructor(private route: ActivatedRoute, private surveyDataService: SurveyDataService) {}

  ngOnInit() {
    this.route.paramMap.subscribe((data) => {
      this.clientId = data.get("data");
      // console.log(data);
      // console.log(this.clientId);
      if (this.clientId != null) {
        this.surveyDataService.getSurveyData(this.clientId)
          .subscribe((surveyResult) => {
            this.data = surveyResult;
          });
      }
    });
  }

}
