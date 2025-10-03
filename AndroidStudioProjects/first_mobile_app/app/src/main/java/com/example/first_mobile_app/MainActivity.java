package com.example.first_mobile_app;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private EditText editTextTask;
    private Button buttonAddTask;
    private LinearLayout linearLayoutTasks;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // View referansları
        editTextTask = findViewById(R.id.editTextTask);
        buttonAddTask = findViewById(R.id.buttonAddTask);
        linearLayoutTasks = findViewById(R.id.linearLayoutTasks);

        // Görev ekleme işlemi
        buttonAddTask.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String task = editTextTask.getText().toString().trim();
                if (!task.isEmpty()) {
                    // Yeni TextView ile görev oluştur
                    final TextView taskView = new TextView(MainActivity.this);
                    taskView.setText(task);
                    taskView.setTextSize(18f);
                    taskView.setPadding(16,16,16,16);
                    taskView.setContentDescription("Görev: " + task);

                    // Çift tıklama ile silme özelliği
                    taskView.setOnClickListener(new View.OnClickListener() {
                        private long lastClickTime = 0;

                        @Override
                        public void onClick(View v) {
                            long clickTime = System.currentTimeMillis();
                            if (clickTime - lastClickTime < 500) { // 0.5 saniye içinde çift tıklama
                                linearLayoutTasks.removeView(taskView);
                            }
                            lastClickTime = clickTime;
                        }
                    });

                    // LinearLayout'a ekle
                    linearLayoutTasks.addView(taskView);

                    // EditText temizle
                    editTextTask.setText("");
                }
            }
        });
    }
}
