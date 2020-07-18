import { Component, OnInit } from '@angular/core';
import { JobService } from '../../services/job.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Job } from 'src/app/shared/models/job.model';

@Component({
  selector: 'app-job',
  templateUrl: './job.component.html',
  styleUrls: ['./job.component.css']
})
export class JobComponent implements OnInit {
  jobForm: FormGroup;
  uploadForm:FormGroup;
  fileToUpload:File = null;
  constructor(private fb: FormBuilder, private jobService: JobService) { }

  ngOnInit() {
    this.jobForm = this.fb.group({
      name: ['', [Validators.required]],
      customerCount:['', [Validators.required]],
      pageCount:['', [Validators.required]]
    });
    this.uploadForm = this.fb.group({
      file:['',[Validators.required]]
    })
  }

  get name() { return this.jobForm.get("name"); }
  get customerCount() { return this.jobForm.get("customerCount"); }
  get pageCount() { return this.jobForm.get("pageCount"); }

  OnSubmit() {
    var newJob = new Job();
    newJob.name = this.name.value;
    newJob.customerCount = this.customerCount.value;
    newJob.pageCount = this.pageCount.value;

    if (this.jobForm.valid) {
      this.jobService.add(newJob).subscribe(
        (res:any)=>{
          console.log(res);
        },
        err=>{
          console.log(err);
        }
      );
    }
  }

  onUpload()
  {
    console.log("uploading...");
    console.log(this.fileToUpload);

    this.jobService.postFile(this.fileToUpload).subscribe(data=>{
      console.log(data)
    },error=>{
      console.log(error)
    });
  }

  handleFileInput(files:FileList)
  {
    this.fileToUpload = files.item(0);
    console.log(this.fileToUpload);
    console.log("File Selected");
  }

}
