# VR-Based Snake Bite Diagnosis Training Game
**Developed in Unity for Medical Student Training**

---

## 1. Introduction
This report outlines the design and implementation of a Virtual Reality (VR) game built using Unity, aimed at training medical students to conduct step-by-step diagnosis for snake bite cases. The game simulates a real-time hospital environment where players interact with medical tools and diagnose a patient’s condition correctly and efficiently within a limited timeframe.

---

## 2. Objective
The main goal of the game is to help users practice correct diagnostic procedures in emergency snakebite scenarios. It ensures that users learn the importance of sequence, timing, and accuracy in treatment.

---

## 3. Gameplay Mechanics

### 3.1 Environment and Setup
- A hospital scene is set with a sample patient on a hospital bed.  
- Players interact using VR controllers to grab and place objects using socket-based placement.  
- Medical equipment includes:
  - Vitals monitor  
  - Breathing mask  
  - Syringe  
  - Blood test lab station  
  - Multiple antivenoms  

### 3.2 VR Controls
- VR controller is required to play the game.  
- Use the joystick on the controller to move around the hospital environment.  
- Press the **A** button on the controller to interact with objects and medical equipment.  
- Controller-based grabbing system allows precise object manipulation.  

### 3.3 Timer and Patient Status
- Game starts at 5 minutes and counts up to 12 minutes.  
- Player has 7 minutes to complete the diagnosis.  
- Timer UI changes color from green (healthy) to red (critical) over time.  
- Patient skin color changes to indicate worsening health.  

---

## 4. Steps to Diagnose and Heal

### 4.1 Check Vitals
Grab the vitals box and place it beside the patient to observe elevated vitals.

### 4.2 Apply Breathing Mask
Grab the mask and place it on the patient’s face to stabilize vitals.

### 4.3 Inspect the Bite
Move close to the patient to trigger the UI panel and click **Inspect Bite** to reveal a cobra bite.

### 4.4 Blood Test
- Grab a syringe and draw blood from the patient.  
- Place it on the lab socket to generate a blood report.  

### 4.5 Choose Antivenom
- Review report and select the correct antivenom from the platform.  
- Apply it to the patient.  

### 4.6 Outcome
- **Correct antivenom:** Timer stops, patient UI says *I am feeling better.*  
- **Wrong antivenom:** Timer continues, UI says *I am not feeling better.*  
- **Time out (after 12 mins):** UI shows *DEATH*, patient turns red.  

---

## 5. Features Implemented
- VR interaction using controller-based grabbing and object sockets.  
- Real-time vitals monitoring and state changes.  
- Step-by-step guided diagnosis process with visual feedback.  
- Timer-based urgency system and visual patient health indication.  
- Conditional UI feedback based on player choices.  

---

## 6. Conclusion
This VR snakebite diagnosis game provides an immersive and interactive way for medical students to simulate real-life emergency treatment. Through clear instructions, responsive tools, and a time-bound challenge, the game effectively trains users to make accurate, timely medical decisions.
